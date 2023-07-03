#include "passivemodestartpage.h"
#include "ui_passivemodestartpage.h"
#include "blglue.h"

PassiveModeStartPage::PassiveModeStartPage(QWidget *parent) :
    BasePage(pgidPassiveModeStart, parent),
    ui(new Ui::PassiveModeStartPage)
{
    ui->setupUi(this);
}

PassiveModeStartPage::~PassiveModeStartPage()
{
    delete ui;
}

void PassiveModeStartPage::on_pushButtonCancel_clicked()
{
    MoveToPage(pgidPassiveModeSettings);
}

