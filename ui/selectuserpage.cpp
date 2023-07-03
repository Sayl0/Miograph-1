#include "selectuserpage.h"
#include "ui_selectuserpage.h"

SelectUserPage::SelectUserPage(QWidget *parent) :
    BasePage(pgidSelectUser,parent),
    ui(new Ui::SelectUserPage)
{
    ui->setupUi(this);
}

SelectUserPage::~SelectUserPage()
{
    delete ui;
}

void SelectUserPage::on_pushButtonCancel_clicked()
{
    MoveToPage( pgidStart );
}


void SelectUserPage::on_pushButtonRegister_clicked()
{
    MoveToPage(pgidUsersRegistration);
}


void SelectUserPage::on_pushButtonEnter_clicked()
{
    if(!connectDB())
    {
        qDebug() << "Не удалось соединиться с базой!";
        QMessageBox::warning(this, "Сообщение","Не удалось соединиться с базой!");
        //return;
        MoveToPage(pgidSelectUser);
    }

    authorizeUser();
}



QString SelectUserPage::getName()
{
    return m_userName;
}

QString SelectUserPage::getPass()
{
    return m_userPass;
}


void SelectUserPage::on_lineEditLogin_textEdited(const QString &arg1)
{
    SelectUserPage::m_userName = arg1;
}



void SelectUserPage::on_lineEditPassword_textEdited(const QString &arg1)
{
    SelectUserPage::m_userPass = arg1;
}

bool SelectUserPage::connectDB()
{
    mw_db = QSqlDatabase::addDatabase("QSQLITE");
    //mw_db.setDatabaseName("C:/work/miograph/miograph.db");
    mw_db.setDatabaseName("miograph.db");
    if(!mw_db.open())
    {
        qDebug() << "Не могу соединиться с базой данных: " << mw_db.lastError();
        QMessageBox::warning(this, "Сообщение","Не могу соединиться с базой данных!");
        return false;
    }
    return true;
}

void SelectUserPage::authorizeUser()
{


    m_userName = getName();
    m_userPass = getPass();


    QString username = "";
    QString userpass = "";

    QSqlQuery query;
    QSqlRecord rec;
    QString temp_str;
    query.prepare("SELECT * FROM users "
                  "WHERE login = :login;");
    query.bindValue(":login", m_userName);

    if(!query.exec())
    {
        qDebug() << "Не могу выполнить запрос SELECT * FROM users WHERE login = :login" << query.lastError() << " : " << query.lastQuery();
        return;
    }
    /*
    if(!query.exec(db_input))
    {
        qDebug() << "Невозможно выполнить запрос - выход " << query.lastError() << " : " << query.lastQuery();
        QMessageBox::warning(this, "Сообщение","Невозможно выполнить запрос - выход!");
    }
    */

    query.next();
    rec = query.record();
    temp_str = rec.value(0).toString();

    username = query.value(rec.indexOf("login")).toString();
    userpass = query.value(rec.indexOf("password")).toString();

    if(m_userName != username || m_userPass != userpass)
    {
        qDebug() << "Пользователь с таким именем и паролем не найден в базе! " << username << " " << userpass;
        m_loginSuccesfull = false;
        QString str_t = "Пользователь с таким именем и паролем не найден в базе! \n" + username + ":" + userpass;
        QMessageBox::warning(this, "Сообщение", str_t);
    }
    else
    {
        m_loginSuccesfull = true;
        QMessageBox::warning(this, "Сообщение","Авторизация прошла успешно!");
    }


}

