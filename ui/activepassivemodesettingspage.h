#ifndef ACTIVEPASSIVEMODESETTINGSPAGE_H
#define ACTIVEPASSIVEMODESETTINGSPAGE_H

#include <QWidget>
#include "page_utils.h"

namespace Ui {
class ActivePassiveModeSettingsPage;
}

class ActivePassiveModeSettingsPage : public BasePage
{
    Q_OBJECT

public:
    explicit ActivePassiveModeSettingsPage(QWidget *parent = nullptr);
    ~ActivePassiveModeSettingsPage();

private slots:
    void on_pushButtonCancel_clicked();

    void on_pushButtonStart_clicked();

    void on_pushButtonDiagnosisAngle_clicked();

    void on_pushButtonDiagnosisAngle_2_clicked();

private:
    Ui::ActivePassiveModeSettingsPage *ui;
};

#endif // ACTIVEPASSIVEMODESETTINGSPAGE_H
