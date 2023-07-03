#include "usersregistrationpage.h"
#include "ui_usersregistrationpage.h"

UsersRegistrationPage::UsersRegistrationPage(QWidget *parent) :
    BasePage(pgidUsersRegistration, parent),
    ui(new Ui::UsersRegistrationPage)
{
    ui->setupUi(this);
}

UsersRegistrationPage::~UsersRegistrationPage()
{
    delete ui;
}

void UsersRegistrationPage::on_pushButtonRegister_clicked()
{
    if(m_FIO.isEmpty())
    {
        qDebug() << "Поле ФИО не может быть пустым";
        QMessageBox::warning(this, "Внимание","Поле ФИО не может быть пустым");
        return;
    }
    if(m_userName.isEmpty())
    {
        qDebug() << "Логин не может быть пустым";
        QMessageBox::warning(this, "Внимание","Логин не может быть пустым");
        return;
    }
    if(m_userPass.isEmpty())
    {
        qDebug() << "Пароль не может быть пустым";
        QMessageBox::warning(this, "Внимание","Пароль не может быть пустым");
        return;
    }
    if(!checkPass())
    {
        qDebug() << "Пароли не совпадают!";
        QMessageBox::warning(this, "Сообщение","Пароли не совпадают!");
        return;
    }
    if(!connectDB())
    {
        qDebug() << "Не удалось соединиться с базой!";
        QMessageBox::warning(this, "Сообщение","Не удалось соединиться с базой!");
        MoveToPage(pgidUsersRegistration);
    }
    if(!checkUserFIO())
    {
        QMessageBox::warning(this, "Сообщение","Пользователь с таким ФИО уже существует!");
        return;
    }

    if(!checkUserLogin())
    {
        QMessageBox::warning(this, "Сообщение","Пользователь с таким логином уже существует!");
        return;
    }

    else
    {
        registerUser();
    }
}


void UsersRegistrationPage::on_pushButtonCancel_clicked()
{
    MoveToPage(pgidSelectUser);
}


void UsersRegistrationPage::on_lineEditFIO_textEdited(const QString &arg1)
{
    UsersRegistrationPage::m_FIO = arg1;
}


void UsersRegistrationPage::on_lineEditLogin_textEdited(const QString &arg1)
{
    UsersRegistrationPage::m_userName = arg1;
}

void UsersRegistrationPage::registerUser()
{

    QSqlQuery query;
    QSqlRecord rec;
    //Этот кусок кода появился из-за очень странного поведения поля типа AUTOINCREMENT в SQLite:
    QString str_t = "SELECT COUNT(*) "
                    "FROM users;";
    db_input = str_t;
    if(!query.exec(db_input))
    {
        qDebug() << "Unable to get number " << query.lastError() << " : " << query.lastQuery();
        return;
    }
    else
    {
        query.next();
        rec = query.record();
        user_counter = rec.value(0).toInt();
        qDebug() << user_counter;
    }

    user_counter++;
    //END of AUTOINCREMENT в SQLite

    query.prepare("INSERT INTO users(id,FIO,login,password) "
                  "VALUES(:id,:FIO, :login, :password);");
    query.bindValue(":id", user_counter);
    query.bindValue(":FIO", m_FIO);
    query.bindValue(":login", m_userName);
    query.bindValue(":password", m_userPass);

    if(!query.exec())
    {
        qDebug() << "Невозможно выполнить INSERT INTO " << query.lastError() << " : " << query.lastQuery();
        QMessageBox::warning(this, "Сообщение","Невозможно выполнить INSERT INTO!");
        return;
    }
    else
    {
        qDebug() << "Пользователь успешно зарегистрирован ";
        QMessageBox::warning(this, "Сообщение","Пользователь успешно зарегистрирован!");
        MoveToPage(pgidStart);
    }



}

bool UsersRegistrationPage::checkUserFIO()
{
    QSqlQuery query;
    QSqlRecord rec;
    QString temp_str;
    query.prepare("SELECT FIO FROM users "
                  "WHERE FIO=:FIO;");
    query.bindValue(":FIO", m_FIO);

    if(!query.exec())
    {
        qDebug() << "Не могу выполнить запрос SELECT FROM users " << query.lastError() << " : " << query.lastQuery();
        return false;
    }
    query.next();
    rec = query.record();
    temp_str = rec.value(0).toString();
    if(temp_str==m_FIO)
    {
        qDebug() << "Пользователь с таким ФИО уже существует";
        return false;
    }
    return true;
}
bool UsersRegistrationPage::checkUserLogin()
{
    QSqlQuery query;
    QSqlRecord rec;
    QString temp_str;
    query.prepare("SELECT login FROM users "
                  "WHERE login=:login;");
    query.bindValue(":login", m_userName);

    if(!query.exec())
    {
        qDebug() << "Не могу выполнить запрос SELECT FROM users " << query.lastError() << " : " << query.lastQuery();
        return false;
    }
    query.next();
    rec = query.record();
    temp_str = rec.value(0).toString();
    if(temp_str==m_userName)
    {
        qDebug() << "Пользователь с таким логином уже существует";
        return false;
    }
    return true;
}

bool UsersRegistrationPage::connectDB()
{
    mw_db = QSqlDatabase::addDatabase("QSQLITE");
    //mw_db.setDatabaseName("C:/work/miograph/miograph.db");
    mw_db.setDatabaseName("miograph.db");
    if(!mw_db.open())
    {
        qDebug() << "Cannot open database: " << mw_db.lastError();
        return false;
    }
    return true;
}

void UsersRegistrationPage::on_lineEditPassword_textEdited(const QString &arg1)
{
    UsersRegistrationPage::m_userPass = arg1;
}

void UsersRegistrationPage::on_lineEditConfirmPassword_textEdited(const QString &arg1)
{
    UsersRegistrationPage::m_confirmation = arg1;
}

QString UsersRegistrationPage::getFIO()
{
    return m_FIO;
}

QString UsersRegistrationPage::getName()
{
    return m_userName;
}

QString UsersRegistrationPage::getPass()
{
    return m_userPass;
}

bool UsersRegistrationPage::checkPass()
{
    return (m_confirmation == m_userPass);
}



