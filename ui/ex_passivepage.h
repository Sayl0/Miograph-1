#ifndef EX_PASSIVEPAGE_H
#define EX_PASSIVEPAGE_H

#include <QWidget>
#include "page_utils.h"
#include <QTimer>

namespace Ui {
class Ex_PassivePage;
}

class Ex_PassivePage : public BasePage
{
    using MyParent = BasePage;
    Q_OBJECT

public:
    explicit Ex_PassivePage(QWidget *parent = nullptr);
    ~Ex_PassivePage();

    virtual void showEvent(QShowEvent *e) override;


private slots:
    void OnTimer();

    void on_pushButton_cancel_clicked();

    void on_pushButton_Exercise_clicked();

    void on_lineEdit_exercise_Duration_textEdited(const QString &arg1);

    void on_lineEdit_speed_Settings_textChanged(const QString &arg1);

    void on_lineEdit_max_Angle_textChanged(const QString &arg1);

    void on_pushButtonDiagnosisAngle_clicked();

private:
    Ui::Ex_PassivePage *ui;
    QTimer mTimer;
    bool mPrevExState = false;

    void ToggleFieldAvailability();

    void DrawAnimation();

    void SetStartButtonText();
};

#endif // EX_PASSIVEPAGE_H
