#ifndef MEASUREFORCELEVELPAGE_H
#define MEASUREFORCELEVELPAGE_H

#include <QWidget>

#include "page_utils.h"

namespace Ui {
class MeasureForceLevelPage;
}

class MeasureForceLevelPage : public BasePage
{
    Q_OBJECT

public:
    explicit MeasureForceLevelPage(QWidget *parent = nullptr);
    ~MeasureForceLevelPage();

private:
    Ui::MeasureForceLevelPage *ui;
};

#endif // MEASUREFORCELEVELPAGE_H
