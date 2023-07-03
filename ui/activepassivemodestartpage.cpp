#include "activepassivemodestartpage.h"
#include "ui_activepassivemodestartpage.h"
#include "blglue.h"

ActivePassiveModeStartPage::ActivePassiveModeStartPage(QWidget *parent) :
    BasePage(pgidActivePassiveModeStart, parent),
    ui(new Ui::ActivePassiveModeStartPage)
{
    ui->setupUi(this);
}

ActivePassiveModeStartPage::~ActivePassiveModeStartPage()
{
    delete ui;
}

void ActivePassiveModeStartPage::on_pushButtonCancel_clicked()
{
    MoveToPage(pgidActivePassiveModeSettings);
}

