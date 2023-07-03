#include "measureforcelevelpage.h"
#include "ui_measureforcelevelpage.h"

MeasureForceLevelPage::MeasureForceLevelPage(QWidget *parent) :
    BasePage( pgidSettingMeasureForceLevel, parent),
    ui(new Ui::MeasureForceLevelPage)
{
    ui->setupUi(this);
}

MeasureForceLevelPage::~MeasureForceLevelPage()
{
    delete ui;
}
