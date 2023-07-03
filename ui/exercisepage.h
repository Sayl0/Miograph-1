#ifndef EXERCISEPAGE_H
#define EXERCISEPAGE_H

#include <QWidget>

#include <QTimer>
#include "page_utils.h"

namespace Ui {
class ExercisePage;
}

class ExercisePage : public BasePage
{
    Q_OBJECT

public:
    explicit ExercisePage(QWidget *parent = nullptr);
    ~ExercisePage();

private slots:
    void OnTimer();
    void on_pushButton_start_pause_exercise_clicked();

    void on_pushButton_stop_exercise_clicked();

    void on_pushButton_extension_clicked();

    void on_pushButton_stop_clicked();

    void on_pushButton_flexion_clicked();

    void on_pushButton_cancel_clicked();

private:
    Ui::ExercisePage *ui;

    QTimer mTimer;

    void SetButtonsAvailability();
};

#endif // EXERCISEPAGE_H
