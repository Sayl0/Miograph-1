#ifndef EXERCISEREPORTSHORTPAGE_H
#define EXERCISEREPORTSHORTPAGE_H

#include <QWidget>

#include "page_utils.h"

namespace Ui {
class ExerciseReportShortPage;
}

class ExerciseReportShortPage : public BasePage
{
    Q_OBJECT

public:
    explicit ExerciseReportShortPage(QWidget *parent = nullptr);
    ~ExerciseReportShortPage();

private:
    Ui::ExerciseReportShortPage *ui;
};

#endif // EXERCISEREPORTSHORTPAGE_H
