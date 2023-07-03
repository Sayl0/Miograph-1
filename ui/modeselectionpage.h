#ifndef MODESELECTIONPAGE_H
#define MODESELECTIONPAGE_H

#include <QWidget>

#include "page_utils.h"

namespace Ui {
class ModeSelectionPage;
}

class ModeSelectionPage : public BasePage
{
    Q_OBJECT

public:
    explicit ModeSelectionPage(QWidget *parent = nullptr);
    ~ModeSelectionPage();

private slots:
    void on_pushButtonExit_clicked();

    void on_pushButtonPassive_clicked();

    void on_pushButtonActivePassive_clicked();

    void on_pushButtonActive_clicked();

    void on_pushButtonAnklePassive_clicked();

private:
    Ui::ModeSelectionPage *ui;
};

#endif // MODESELECTIONPAGE_H
