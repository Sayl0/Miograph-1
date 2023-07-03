#ifndef STARTPAGE_H
#define STARTPAGE_H

#include <QWidget>
#include <QHelpEngine>
#include <QHelpContentWidget>
#include <QHelpIndexWidget>
#include <QHelpSearchQueryWidget>
#include <QTextBrowser>
#include <QDebug>
#include <QMessageBox>

#include <QTableWidget>
#include <QDockWidget>
#include <QSplitter>
#include <QTabWidget>
#include <QMainWindow>
#include <QDockWidget>

#include "page_utils.h"

namespace Ui {
class StartPage;
}

class StartPage : public BasePage
{
    Q_OBJECT

public:
    explicit StartPage(QWidget *parent = nullptr);
    ~StartPage();

private slots:
    void on_pushButton_fast_start_clicked();

    void on_pushButton_select_user_clicked();

    void on_pushButton_users_manual_clicked();

    void on_pushButton_exit_clicked();

private:
    Ui::StartPage *ui;
    QDockWidget* helpWindow;
};

#endif // STARTPAGE_H
