#ifndef EXERCISEREPORTFULLPAGE_H
#define EXERCISEREPORTFULLPAGE_H

#include <QWidget>

#include "page_utils.h"

namespace Ui {
class ExerciseReportFullPage;
}

class ExerciseReportFullPage : public BasePage
{
    Q_OBJECT

public:
    explicit ExerciseReportFullPage(QWidget *parent = nullptr);
    ~ExerciseReportFullPage();

private slots:
    void on_pushButton_end_session_clicked();

private:
    Ui::ExerciseReportFullPage *ui;
};

#endif // EXERCISEREPORTFULLPAGE_H
