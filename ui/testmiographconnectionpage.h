#ifndef TESTMIOGRAPHCONNECTIONPAGE_H
#define TESTMIOGRAPHCONNECTIONPAGE_H

#include <QWidget>
#include "page_utils.h"

namespace Ui {
class TestMiographConnectionPage;
}

class TestMiographConnectionPage : public BasePage
{
    Q_OBJECT

public:
    explicit TestMiographConnectionPage(QWidget *parent = nullptr);
    ~TestMiographConnectionPage();

private:
    Ui::TestMiographConnectionPage *ui;
};

#endif // TESTMIOGRAPHCONNECTIONPAGE_H
