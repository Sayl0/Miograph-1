#ifndef ACTIVEMODESTARTPAGE_H
#define ACTIVEMODESTARTPAGE_H

#include <QWidget>
#include <QTimer>
#include "page_utils.h"


namespace Ui {
class ActiveModeStartPage;
}

class ActiveModeStartPage : public BasePage
{
    using MyParent = BasePage;
    Q_OBJECT

public:
    explicit ActiveModeStartPage(QWidget *parent = nullptr);
    ~ActiveModeStartPage();

    //virtual void showEvent(QShowEvent *e) override;

private slots:
    void OnTimer();

    void on_pushButton_start_pause_exercise_clicked();

    void on_pushButton_stop_clicked();

    void on_pushButton_stop_exercise_clicked();

private:
    Ui::ActiveModeStartPage *ui;
    QTimer mTimer;

    void SetButtonsAvailability();
};

#endif // ACTIVEMODESTARTPAGE_H
