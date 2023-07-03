#ifndef PASSIVEMODESTARTPAGE_H
#define PASSIVEMODESTARTPAGE_H

#include <QWidget>
#include "page_utils.h"


namespace Ui {
class PassiveModeStartPage;
}

class PassiveModeStartPage : public BasePage
{
    Q_OBJECT

public:
    explicit PassiveModeStartPage(QWidget *parent = nullptr);
    ~PassiveModeStartPage();

private slots:
    void on_pushButtonCancel_clicked();

private:
    Ui::PassiveModeStartPage *ui;
};

#endif // PASSIVEMODESTARTPAGE_H
