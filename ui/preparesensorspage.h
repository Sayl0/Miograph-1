#ifndef PREPARESENSORSPAGE_H
#define PREPARESENSORSPAGE_H

#include <QWidget>
#include "page_utils.h"

namespace Ui {
class PrepareSensorsPage;
}

class PrepareSensorsPage : public BasePage
{
    Q_OBJECT

public:
    explicit PrepareSensorsPage(QWidget *parent = nullptr);
    ~PrepareSensorsPage();

private:
    Ui::PrepareSensorsPage *ui;
};

#endif // PREPARESENSORSPAGE_H
