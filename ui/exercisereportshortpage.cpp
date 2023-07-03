#include "exercisereportshortpage.h"
#include "ui_exercisereportshortpage.h"

ExerciseReportShortPage::ExerciseReportShortPage(QWidget *parent) :
    BasePage( pgidReportShort, parent),
    ui(new Ui::ExerciseReportShortPage)
{
    ui->setupUi(this);
}

ExerciseReportShortPage::~ExerciseReportShortPage()
{
    delete ui;
}
