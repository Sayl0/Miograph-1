#ifndef PASSIVEMODESETTINGSPAGE_H
#define PASSIVEMODESETTINGSPAGE_H

#include <QWidget>
#include "page_utils.h"


namespace Ui {
class PassiveModeSettingsPage;
}

class PassiveModeSettingsPage : public BasePage
{
    Q_OBJECT

public:
    explicit PassiveModeSettingsPage(QWidget *parent = nullptr);
    ~PassiveModeSettingsPage();

private slots:
    void on_pushButtonCancel_clicked();

    void on_pushButtonStart_clicked();

    void on_pushButtonDiagnosisAngle_clicked();

private:
    Ui::PassiveModeSettingsPage *ui;
};

#endif // PASSIVEMODESETTINGSPAGE_H
