#ifndef SELECTSESSIONLISTPAGE_H
#define SELECTSESSIONLISTPAGE_H

#include <QWidget>

#include "page_utils.h"

namespace Ui {
class SelectSessionListPage;
}

class SelectSessionListPage : public BasePage
{
    Q_OBJECT

public:
    explicit SelectSessionListPage( QWidget *parent = nullptr );
    ~SelectSessionListPage();

private slots:
    void on_pushButton_begin_session_clicked();

    void on_pushButton_TestMode_clicked();

    void on_pushButton_exit_clicked();

    void on_doubleSpinBox_gain_1_valueChanged(double arg1);

    void on_doubleSpinBox_gain_2_valueChanged(double arg1);

    void on_doubleSpinBox_gain_3_valueChanged(double arg1);

    void on_doubleSpinBox_gain_4_valueChanged(double arg1);

    void on_pushButton_passive_mode_clicked();

    void on_pushButton_active_passive_mode_clicked();

private:
    Ui::SelectSessionListPage *ui;
};

#endif // SELECTSESSIONLISTPAGE_H
