#ifndef LEGBENDMEASUREPAGE_H
#define LEGBENDMEASUREPAGE_H

#include <QWidget>

#include "page_utils.h"
#include <QTimer>

namespace Ui {
class LegBendMeasurePage;
}

class LegBendMeasurePage : public BasePage
{
    using MyParent = BasePage;
    Q_OBJECT

public:
    explicit LegBendMeasurePage(QWidget *parent = nullptr);
    virtual ~LegBendMeasurePage() override;

    virtual void showEvent(QShowEvent *e) override;
    virtual void hideEvent(QHideEvent *e) override;

private slots:
    void OnTimer();

    void on_pushButton_flexion_clicked();

    void on_pushButton_extension_clicked();

    void on_pushButton_stop_clicked();

private:
    Ui::LegBendMeasurePage *ui;

    QTimer mTimer;
};

#endif // LEGBENDMEASUREPAGE_H
