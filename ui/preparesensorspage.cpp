#include "preparesensorspage.h"
#include "ui_preparesensorspage.h"

PrepareSensorsPage::PrepareSensorsPage(QWidget *parent) :
    BasePage( pgidPrepareSensors, parent),
    ui(new Ui::PrepareSensorsPage)
{
    ui->setupUi(this);
}

PrepareSensorsPage::~PrepareSensorsPage()
{
    delete ui;
}
