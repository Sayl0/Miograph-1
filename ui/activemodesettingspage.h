#ifndef ACTIVEMODESETTINGSPAGE_H
#define ACTIVEMODESETTINGSPAGE_H

#include <QWidget>
#include "page_utils.h"


namespace Ui {
class ActiveModeSettingsPage;
}

class ActiveModeSettingsPage : public BasePage
{
    using MyParent = BasePage;
    Q_OBJECT

public:
    explicit ActiveModeSettingsPage(QWidget *parent = nullptr);
    ~ActiveModeSettingsPage();

    virtual void showEvent(QShowEvent *e) override;

private slots:

    void on_pushButtonDiagnosisAngle_clicked();

    void on_pushButtonDiagnosisAngle_2_clicked();

    void on_pushButtonDiagnosisAngle_3_clicked();

    void on_pushButton_forward_clicked();

private:
    Ui::ActiveModeSettingsPage *ui;
};

#endif // ACTIVEMODESETTINGSPAGE_H
