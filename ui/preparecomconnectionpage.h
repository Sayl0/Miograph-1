#ifndef PREPARECOMCONNECTIONPAGE_H
#define PREPARECOMCONNECTIONPAGE_H

#include <QWidget>

#include "page_utils.h"

namespace Ui {
class PrepareComConnectionPage;
}

class PrepareComConnectionPage : public BasePage
{
    Q_OBJECT

public:
    explicit PrepareComConnectionPage(QWidget *parent = nullptr);
    ~PrepareComConnectionPage();

private:
    Ui::PrepareComConnectionPage *ui;
};

#endif // PREPARECOMCONNECTIONPAGE_H
