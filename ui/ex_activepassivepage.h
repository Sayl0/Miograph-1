#ifndef EX_ACTIVEPASSIVEPAGE_H
#define EX_ACTIVEPASSIVEPAGE_H

#include <QWidget>
#include "page_utils.h"
#include <QTimer>

namespace Ui {
class Ex_ActivePassivePage;
}

class Ex_ActivePassivePage : public BasePage
{
    using MyParent = BasePage;
    Q_OBJECT

    virtual void showEvent(QShowEvent *e) override;
public:
    explicit Ex_ActivePassivePage(QWidget *parent = nullptr);
    ~Ex_ActivePassivePage();

private slots:
    void OnTimer();

    void on_pushButton_cancel_clicked();

    void on_pushButton_exercise_clicked();

    void on_pushButton_diagnostics_clicked();

    void on_lineEdit_exercise_duration_textEdited(const QString &arg1);

    void on_lineEdit__steps_count_textChanged(const QString &arg1);

    void on_lineEdit_max_angle_textChanged(const QString &arg1);

    void on_pushButton_diagnostics_ankle_clicked();

private:
    Ui::Ex_ActivePassivePage *ui;
    QTimer mTimer;
    bool mPrevExState = false;

    void DrawAnimation();

    void SetStartButtonText();
};

#endif // EX_ACTIVEPASSIVEPAGE_H
