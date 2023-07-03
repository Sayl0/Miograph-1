#ifndef EX_ANKLEPASSIVEPAGE_H
#define EX_ANKLEPASSIVEPAGE_H

#include <QWidget>
#include "page_utils.h"
#include <QTimer>

namespace Ui {
class Ex_AnklePassivePage;
}

class Ex_AnklePassivePage : public BasePage
{
    using MyParent = BasePage;
    Q_OBJECT

public:
    explicit Ex_AnklePassivePage(QWidget *parent = nullptr);
    ~Ex_AnklePassivePage();

    virtual void showEvent(QShowEvent *e) override;

private slots:
    void OnTimer();

    void on_pushButton_Exercise_clicked();

    void on_pushButton_cancel_clicked();

private:
    Ui::Ex_AnklePassivePage *ui;
    QTimer mTimer;
    bool mPrevExState = false;

    void ToggleFieldAvailability();

    void DrawAnimation();

    void SetStartButtonText();
};

#endif // EX_ANKLEPASSIVEPAGE_H
