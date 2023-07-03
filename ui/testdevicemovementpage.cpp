#include "testdevicemovementpage.h"
#include "ui_testdevicemovementpage.h"

TestDeviceMovementPage::TestDeviceMovementPage(QWidget *parent) :
    BasePage( pgidPrepareCheckMovement, parent),
    ui(new Ui::TestDeviceMovementPage)
{
    ui->setupUi(this);
}

TestDeviceMovementPage::~TestDeviceMovementPage()
{
    delete ui;
}
