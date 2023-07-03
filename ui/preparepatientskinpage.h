#ifndef PREPAREPATIENTSKINPAGE_H
#define PREPAREPATIENTSKINPAGE_H

#include <QWidget>

#include "page_utils.h"

namespace Ui {
class PreparePatientSkinPage;
}

class PreparePatientSkinPage : public BasePage
{
    Q_OBJECT

public:
    explicit PreparePatientSkinPage( QWidget *parent = nullptr );
    ~PreparePatientSkinPage();

private slots:
    /*void on_pushButton_forward_clicked();

    void on_pushButton_cancel_clicked();*/

private:
    Ui::PreparePatientSkinPage *ui;
};

#endif // PREPAREPATIENTSKINPAGE_H
