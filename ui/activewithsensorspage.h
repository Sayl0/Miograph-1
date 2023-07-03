#ifndef ACTIVEWITHSENSORSPAGE_H
#define ACTIVEWITHSENSORSPAGE_H

#include <QWidget>

#include "page_utils.h"
#include <QTimer>

namespace Ui {
class ActiveWithSensorsPage;
}

class ActiveWithSensorsPage : public BasePage
{
    using MyParent = BasePage;
    Q_OBJECT

    virtual void showEvent(QShowEvent *e) override;
public:
    explicit ActiveWithSensorsPage(QWidget *parent = nullptr);
    ~ActiveWithSensorsPage();

private slots:
    void OnTimer();

    void on_pushButton_exercise_clicked();

    void on_pushButton_cancel_clicked();

    void on_lineEdit_exercise_duration_textEdited(const QString &arg1);

    void on_lineEdit_speed_settings_textChanged(const QString &arg1);

    void on_lineEdit_max_angle_textChanged(const QString &arg1);

    void on_lineEdit__steps_count_textChanged(const QString &arg1);

    void on_pushButton_to_start_pos_clicked();

    void on_pushButton_to_end_pos_clicked();

    void on_pushButton_ToMaxAngle_clicked();

    void on_pushButton_diagnostics_clicked();

    void on_lineEdit_tenzo_1_textEdited(const QString &arg1);

    void on_lineEdit_tenzo_2_textEdited(const QString &arg1);

    void on_lineEdit_tenzo_error_textEdited(const QString &arg1);

private:
    Ui::ActiveWithSensorsPage *ui;
    QTimer mTimer;
    bool mPrevExState = false;

    void DrawAnimation();

    void SetStartButtonText();
};

#endif // ACTIVEWITHSENSORSPAGE_H
