#include "diagnosismaxstrengthcomppage.h"
#include "ui_diagnosismaxstrengthcomppage.h"
#include "blglue.h"

DiagnosisMaxStrengthCompPage::DiagnosisMaxStrengthCompPage(QWidget *parent) :
    BasePage(pgidDiagnosisMaxStrengthComp, parent),
    ui(new Ui::DiagnosisMaxStrengthCompPage)
{
    ui->setupUi(this);
}

DiagnosisMaxStrengthCompPage::~DiagnosisMaxStrengthCompPage()
{
    delete ui;
}
