#ifndef USERSREGISTRATIONPAGE_H
#define USERSREGISTRATIONPAGE_H

#include <QWidget>
#include <QtSql/QtSql>
#include <QMessageBox>
#include "page_utils.h"

namespace Ui {
class UsersRegistrationPage;
}

class UsersRegistrationPage : public BasePage
{
    Q_OBJECT

public:
    explicit UsersRegistrationPage(QWidget *parent = nullptr);
    ~UsersRegistrationPage();
    QString getFIO();
    QString getName();
    QString getPass();
    bool checkPass();

private slots:
    void on_pushButtonRegister_clicked();

    void on_pushButtonCancel_clicked();

    void on_lineEditFIO_textEdited(const QString &arg1);

    void on_lineEditLogin_textEdited(const QString &arg1);

    void on_lineEditPassword_textEdited(const QString &arg1);

    void on_lineEditConfirmPassword_textEdited(const QString &arg1);

private:
    Ui::UsersRegistrationPage *ui;
    QString m_FIO;
    QString m_userName;
    QString m_userPass;
    QString m_confirmation;
    void registerUser();
    bool connectDB();// прототип метода подключения к БД
    QString db_input; // строка для отправки запроса к БД
    QSqlDatabase mw_db; // экземпляр подключения к БД
    int user_counter; // счетчик пользователей
    //bool checkUser(); // проверка пользователя на уникальность
    bool checkUserFIO(); // проверка ФИО пользователя на уникальность
    bool checkUserLogin(); // проверка логина пользователя на уникальность
};

#endif // USERSREGISTRATIONPAGE_H
