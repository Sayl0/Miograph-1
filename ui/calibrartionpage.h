#ifndef CALIBRARTIONPAGE_H
#define CALIBRARTIONPAGE_H

#include <QWidget>
#include <QTimer>
#include <set>

#include "page_utils.h"


namespace Ui {
class CalibrartionPage;
}

class CalibrartionPage : public BasePage
{
    using MyParent = BasePage;
    Q_OBJECT

public:
    explicit CalibrartionPage(QWidget *parent = nullptr);
    ~CalibrartionPage();

private slots:
    void OnTimer();
    void OnCalibrationTimer();

    void on_pushButton_calibrate_clicked();

private:
    Ui::CalibrartionPage *ui;

    QTimer mTimer;
    std::set<std::pair<int, double> > mCalibrationConfig;

    void LockCalibrationControl( bool lock );

};

#endif // CALIBRARTIONPAGE_H
