#ifndef DIAGNOSISANGLEPAGE_H
#define DIAGNOSISANGLEPAGE_H

#include <QWidget>
#include "page_utils.h"
#include <QTimer>

namespace Ui {
class DiagnosisAnglePage;
}

class DiagnosisAnglePage : public BasePage
{
    using MyParent = BasePage;
    Q_OBJECT

public:
    explicit DiagnosisAnglePage(QWidget *parent = nullptr);
    virtual ~DiagnosisAnglePage() override;
    virtual void showEvent(QShowEvent *e) override;
    virtual void hideEvent(QHideEvent *e) override;

private slots:
    void OnTimer();

    void on_pushButton_flexion_clicked();

    void on_pushButton_stop_clicked();

    void on_pushButton_extension_clicked();

private:
    Ui::DiagnosisAnglePage *ui;
    QTimer mTimer;
};

#endif // DIAGNOSISANGLEPAGE_H
