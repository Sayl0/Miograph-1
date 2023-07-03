#include "modeselectionpage.h"
#include "ui_modeselectionpage.h"

#include "blglue.h"

ModeSelectionPage::ModeSelectionPage(QWidget *parent) :
    BasePage(pgidModeSelection, parent),
    ui(new Ui::ModeSelectionPage)
{
    ui->setupUi(this);
}

ModeSelectionPage::~ModeSelectionPage()
{
    delete ui;
}

void ModeSelectionPage::on_pushButtonExit_clicked()
{
    MoveToPage(pgidStart);
}


void ModeSelectionPage::on_pushButtonPassive_clicked()
{
    MoveToPage(pgidEx_Passive, Page());
}


void ModeSelectionPage::on_pushButtonActivePassive_clicked()
{
    MoveToPage(pgidEx_ActivePassive, Page());
}


void ModeSelectionPage::on_pushButtonActive_clicked()
{
    MoveToPage(pgidActiveModeSettings, Page());
    //MoveToPage(pgidEx_Active, Page());
}


void ModeSelectionPage::on_pushButtonAnklePassive_clicked()
{
    MoveToPage(pgidEx_AnklePassive, Page());
}

