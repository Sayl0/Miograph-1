#ifndef EX_ACTIVEPAGE_H
#define EX_ACTIVEPAGE_H

#include <QWidget>
#include "page_utils.h"
#include <QTimer>

namespace Ui {
class Ex_ActivePage;
}

class Ex_ActivePage : public BasePage
{
    Q_OBJECT
public:
    explicit Ex_ActivePage(QWidget *parent = nullptr);
    ~Ex_ActivePage();

private slots:
    void OnTimer();

    void on_pushButton_cancel_clicked();

    void on_pushButton_exercise_clicked();

    void on_pushButton_diagnostics_clicked();

    void on_pushButton_diagnostics_2_clicked();

    void on_pushButton_diagnostics_3_clicked();

private:
    Ui::Ex_ActivePage *ui;

    QTimer mTimer;

    void SetButtonsAvailability();

    void SetLabelsVisible();

    void SetLabelsInvisible();
};

#endif // EX_ACTIVEPAGE_H
