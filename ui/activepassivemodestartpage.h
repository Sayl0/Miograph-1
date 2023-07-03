#ifndef ACTIVEPASSIVEMODESTARTPAGE_H
#define ACTIVEPASSIVEMODESTARTPAGE_H

#include <QWidget>
#include "page_utils.h"


namespace Ui {
class ActivePassiveModeStartPage;
}

class ActivePassiveModeStartPage : public BasePage
{
    Q_OBJECT

public:
    explicit ActivePassiveModeStartPage(QWidget *parent = nullptr);
    ~ActivePassiveModeStartPage();

private slots:
    void on_pushButtonCancel_clicked();

private:
    Ui::ActivePassiveModeStartPage *ui;
};

#endif // ACTIVEPASSIVEMODESTARTPAGE_H
