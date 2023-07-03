#ifndef DIAGNOSISMAXSTRENGTHCOMPPAGE_H
#define DIAGNOSISMAXSTRENGTHCOMPPAGE_H

#include <QWidget>
#include "page_utils.h"

namespace Ui {
class DiagnosisMaxStrengthCompPage;
}

class DiagnosisMaxStrengthCompPage : public BasePage
{
    Q_OBJECT

public:
    explicit DiagnosisMaxStrengthCompPage(QWidget *parent = nullptr);
    ~DiagnosisMaxStrengthCompPage();

private:
    Ui::DiagnosisMaxStrengthCompPage *ui;
};

#endif // DIAGNOSISMAXSTRENGTHCOMPPAGE_H
