#include "passivemodesettingspage.h"
#include "ui_passivemodesettingspage.h"
#include "blglue.h"

PassiveModeSettingsPage::PassiveModeSettingsPage(QWidget *parent) :
    BasePage(pgidPassiveModeSettings, parent),
    ui(new Ui::PassiveModeSettingsPage)
{
    ui->setupUi(this);
}

PassiveModeSettingsPage::~PassiveModeSettingsPage()
{
    delete ui;
}

void PassiveModeSettingsPage::on_pushButtonCancel_clicked()
{
    MoveToPage(pgidModeSelection);
}


void PassiveModeSettingsPage::on_pushButtonStart_clicked()
{
    MoveToPage(pgidPassiveModeStart);
}


void PassiveModeSettingsPage::on_pushButtonDiagnosisAngle_clicked()
{
    MoveToPage(pgidDiagnosisAngle, pgidPassiveModeSettings);
}

