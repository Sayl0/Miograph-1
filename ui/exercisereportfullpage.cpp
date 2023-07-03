#include "exercisereportfullpage.h"
#include "ui_exercisereportfullpage.h"

ExerciseReportFullPage::ExerciseReportFullPage(QWidget *parent) :
    BasePage( pgidReportFull, parent ),
    ui(new Ui::ExerciseReportFullPage)
{
    ui->setupUi(this);
}

ExerciseReportFullPage::~ExerciseReportFullPage()
{
    delete ui;
}

void ExerciseReportFullPage::on_pushButton_end_session_clicked()
{
    /*
     Galim
    */
    //MoveToPage( pgidSelectSession );
    MoveToPage( pgidStart );
}
