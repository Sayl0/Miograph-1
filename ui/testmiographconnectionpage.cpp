#include "testmiographconnectionpage.h"
#include "ui_testmiographconnectionpage.h"

TestMiographConnectionPage::TestMiographConnectionPage(QWidget *parent) :
    BasePage( pgidPrepareMiograph, parent),
    ui(new Ui::TestMiographConnectionPage)
{
    ui->setupUi(this);
}

TestMiographConnectionPage::~TestMiographConnectionPage()
{
    delete ui;
}
