#ifndef SHOWHELPPAGE_H
#define SHOWHELPPAGE_H

#include <QWidget>
#include <QHelpEngine>
#include <QTextBrowser>
#include <QDebug>
#include <QMessageBox>

#include "page_utils.h"


namespace Ui {
class ShowHelpPage;
}

class ShowHelpPage : public BasePage
{
    Q_OBJECT

public:
    explicit ShowHelpPage(QWidget *parent = nullptr);
    ~ShowHelpPage();

private slots:
    void on_pushButtonCancel_clicked();

private:
    Ui::ShowHelpPage *ui;
    void SetupHelpWindow();
};



#endif // SHOWHELPPAGE_H
