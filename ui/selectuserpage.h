#ifndef SELECTUSERPAGE_H
#define SELECTUSERPAGE_H

#include <QWidget>
#include <QString>
#include <QtSql/QtSql>
#include <QCryptographicHash>
#include <QMessageBox>
#include "page_utils.h"


namespace Ui {
class SelectUserPage;
}

class SelectUserPage : public BasePage
{
    Q_OBJECT

public:
    explicit SelectUserPage(QWidget *parent = nullptr);
    ~SelectUserPage();
    QString getName();
    QString getPass();

private slots:
    void on_pushButtonCancel_clicked();

    void on_pushButtonRegister_clicked();

    void on_pushButtonEnter_clicked();

    void on_lineEditLogin_textEdited(const QString &arg1);

    void on_lineEditPassword_textEdited(const QString &arg1);

private:
    Ui::SelectUserPage *ui;
    void authorizeUser();
    QString m_FIO;
    QString m_userName;
    QString m_userPass;
    QString m_confirmation;
    void registerUser();
    bool connectDB();// прототип метода подключения к БД
    QString db_input; // строка для отправки запроса к БД
    QSqlDatabase mw_db; // экземпляр подключения к БД
    bool m_loginSuccesfull; // флаг успешной авторизации
};

#endif // SELECTUSERPAGE_H
