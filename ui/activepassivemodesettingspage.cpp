#include "activepassivemodesettingspage.h"
#include "ui_activepassivemodesettingspage.h"
#include "blglue.h"

ActivePassiveModeSettingsPage::ActivePassiveModeSettingsPage(QWidget *parent) :
    BasePage(pgidActivePassiveModeSettings, parent),
    ui(new Ui::ActivePassiveModeSettingsPage)
{
    ui->setupUi(this);
}

ActivePassiveModeSettingsPage::~ActivePassiveModeSettingsPage()
{
    delete ui;
}

void ActivePassiveModeSettingsPage::on_pushButtonCancel_clicked()
{
    MoveToPage(pgidModeSelection);
}


void ActivePassiveModeSettingsPage::on_pushButtonStart_clicked()
{
    MoveToPage(pgidActivePassiveModeStart);
}


void ActivePassiveModeSettingsPage::on_pushButtonDiagnosisAngle_clicked()
{
    MoveToPage(pgidDiagnosisAngle, pgidActivePassiveModeSettings);
}


void ActivePassiveModeSettingsPage::on_pushButtonDiagnosisAngle_2_clicked()
{
    MoveToPage(pgidDiagnosisAnkleMobStr, pgidActiveModeSettings);
}

