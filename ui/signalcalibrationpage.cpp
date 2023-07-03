#include "signalcalibrationpage.h"
#include "ui_signalcalibrationpage.h"
#include "blglue.h"

SignalCalibrationPage::SignalCalibrationPage(QWidget *parent) :
    BasePage(pgidSignalCalibration, parent),
    ui(new Ui::SignalCalibrationPage)
{
    ui->setupUi(this);
}

SignalCalibrationPage::~SignalCalibrationPage()
{
    delete ui;
}

void SignalCalibrationPage::on_pushButtonCancel_clicked()
{
    Backward();
}

