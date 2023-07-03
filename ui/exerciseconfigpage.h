#ifndef EXERCISECONFIGPAGE_H
#define EXERCISECONFIGPAGE_H

#include <QWidget>

#include "page_utils.h"

namespace Ui {
class ExerciseConfigPage;
}

class ExerciseConfigPage : public BasePage
{
    using MyParent = BasePage;
    Q_OBJECT

public:
    explicit ExerciseConfigPage(QWidget *parent = nullptr);
    ~ExerciseConfigPage();

    virtual void showEvent(QShowEvent *e) override;

private slots:
    void on_pushButton_forward_clicked();

    void on_pushButton_to_start_pos_clicked();

    void on_pushButton_calibration_clicked();

    void on_pushButton_diagnostics_clicked();

private:
    Ui::ExerciseConfigPage *ui;
};

#endif // EXERCISECONFIGPAGE_H
