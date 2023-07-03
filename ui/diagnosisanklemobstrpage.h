#ifndef DIAGNOSISANKLEMOBSTRPAGE_H
#define DIAGNOSISANKLEMOBSTRPAGE_H

#include <QWidget>
#include "page_utils.h"
#include <QTimer>

namespace Ui {
class DiagnosisAnkleMobStrPage;
}

class DiagnosisAnkleMobStrPage : public BasePage
{
    using MyParent = BasePage;
    Q_OBJECT

public:
    explicit DiagnosisAnkleMobStrPage(QWidget *parent = nullptr);
    virtual ~DiagnosisAnkleMobStrPage() override;
    virtual void showEvent(QShowEvent *e) override;
    virtual void hideEvent(QHideEvent *e) override;

private slots:
    void OnTimer();

    void on_lineEdit_flexion_textEdited(const QString &arg1);

    void on_lineEdit_tenzo_error_textEdited(const QString &arg1);

    void on_lineEdit_extension_textEdited(const QString &arg1);

private:
    Ui::DiagnosisAnkleMobStrPage *ui;
    QTimer mTimer;
};

#endif // DIAGNOSISANKLEMOBSTRPAGE_H
