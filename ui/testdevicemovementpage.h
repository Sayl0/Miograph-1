#ifndef TESTDEVICEMOVEMENTPAGE_H
#define TESTDEVICEMOVEMENTPAGE_H

#include <QWidget>

#include "page_utils.h"

namespace Ui {
class TestDeviceMovementPage;
}

class TestDeviceMovementPage : public BasePage
{
    Q_OBJECT

public:
    explicit TestDeviceMovementPage(QWidget *parent = nullptr);
    ~TestDeviceMovementPage();

private:
    Ui::TestDeviceMovementPage *ui;
};

#endif // TESTDEVICEMOVEMENTPAGE_H
