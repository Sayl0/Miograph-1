#include "preparecomconnectionpage.h"
#include "ui_preparecomconnectionpage.h"

PrepareComConnectionPage::PrepareComConnectionPage(QWidget *parent) :
    BasePage( pgidPrepareComPort, parent),
    ui(new Ui::PrepareComConnectionPage)
{
    ui->setupUi(this);
}

PrepareComConnectionPage::~PrepareComConnectionPage()
{
    delete ui;
}
