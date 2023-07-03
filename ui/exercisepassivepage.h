#ifndef EXERCISEPASSIVEPAGE_H
#define EXERCISEPASSIVEPAGE_H

#include <QWidget>
#include "page_utils.h"
#include <QTimer>

namespace Ui {
class ExercisePassivePage;
}

class ExercisePassivePage : public BasePage
{
    using MyParent = BasePage;
    Q_OBJECT

public:
    explicit ExercisePassivePage(QWidget *parent = nullptr);
    ~ExercisePassivePage();

    virtual void showEvent(QShowEvent *e) override;

private slots:
    void OnTimer();

    void on_pushButton_exercise_clicked();

    void on_pushButton_cancel_clicked();

    void on_lineEdit_exercise_duration_textEdited(const QString &arg1);

    void on_lineEdit_speed_settings_textChanged(const QString &arg1);

    void on_lineEdit_max_angle_textChanged(const QString &arg1);

    void on_lineEdit__steps_count_textChanged(const QString &arg1);

    void on_pushButton_to_start_pos_clicked();

    void on_lineEdit_tenzo_error_textChanged(const QString &arg1);

    void on_lineEdit_coeff_textEdited(const QString &arg1);

    void on_pushButton_to_pos_clicked();

    void on_pushButton_to_end_pos_clicked();

    void on_pushButton_ToMaxAngle_clicked();

    void on_pushButton_diagnostics_clicked();

private:
    Ui::ExercisePassivePage *ui;
    QTimer mTimer;
    bool mPrevExState = false;

    void ToggleFieldAvailability();

    void DrawAnimation();

    void SetStartButtonText();
};

#endif // EXERCISEPASSIVEPAGE_H
