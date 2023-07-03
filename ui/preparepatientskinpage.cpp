#include "preparepatientskinpage.h"
#include "ui_preparepatientskinpage.h"

PreparePatientSkinPage::PreparePatientSkinPage(QWidget *parent) :
    BasePage( pgidPreparePatientSkin, parent ),
    ui(new Ui::PreparePatientSkinPage)
{
    ui->setupUi(this);
}

PreparePatientSkinPage::~PreparePatientSkinPage()
{
    delete ui;
}

/*void PreparePatientSkinPage::on_pushButton_forward_clicked()
{
    Forward();
}

void PreparePatientSkinPage::on_pushButton_cancel_clicked()
{
    Cancel();
}*/
