#ifndef SIGNALCALIBRATIONPAGE_H
#define SIGNALCALIBRATIONPAGE_H

#include <QWidget>
#include "page_utils.h"

namespace Ui {
class SignalCalibrationPage;
}

class SignalCalibrationPage : public BasePage
{
    Q_OBJECT

public:
    explicit SignalCalibrationPage(QWidget *parent = nullptr);
    ~SignalCalibrationPage();

private slots:
    void on_pushButtonCancel_clicked();

private:
    Ui::SignalCalibrationPage *ui;
};

#endif // SIGNALCALIBRATIONPAGE_H
