#ifndef PAGE_UTILS_H
#define PAGE_UTILS_H

#include <QWidget>
#include <QStackedWidget>
#include <simplelogger.h>
#include <memory>
#include <QStack>

extern const quint8 DEFAULT_LEG_POS;


enum PageIndexId: int
{
    /*
    Galim:
    Поменяем стартовую страницу
    */
    //pgidSelectSession = 0,
    pgidStart = 0,
    pgidSelectUser,
    pgidUsersRegistration,
    pgidShowHelp,
    pgidModeSelection,
    pgidPassiveModeSettings,
    pgidPassiveModeStart,
    pgidActivePassiveModeSettings,
    pgidActivePassiveModeStart,
    pgidActiveModeSettings,
    pgidActiveModeStart,
    pgidDiagnosisAngle,
    pgidDiagnosisMaxStrength,
    pgidSignalCalibration,
    pgidDiagnosisMaxStrengthComp,
    pgidDiagnosisAnkleMobStr,
    pgidEx_Passive,
    pgidEx_ActivePassive,
    pgidEx_Active,
    pgidEx_AnklePassive,

    pgidCMiographTester,

    pgidSettingCalibration,

    pgidSettingLegBend,
    pgidExerciseConfig,
    pgidExercise,
    pgidExercisePassive,
    pgidExerciseWithTenzosensors,
    pgidEND,

    pgidPreparePatientSkin,
    pgidPrepareSensors,
    pgidPrepareComPort,
    pgidPrepareCheckMovement,
    pgidPrepareMiograph,
    pgidSettingMeasureForceLevel,

    pgidReportShort,
    pgidReportFull
};

static QStack<PageIndexId> RETURN_PAGE_ID_S;

quint16 AngleFromPos( quint16 pos );

quint8 GetLevelFromStreamHandler( int stream_handler_idx );

class BasePage : public QWidget
{
    using MyParent = QWidget;
    Q_OBJECT
public:
    explicit BasePage( PageIndexId page, QWidget *parent = nullptr);

    PageIndexId Page() const;

signals:
    void SignalCancel();
    void SignalForward();
    void SignalBack();
    void SignalMoveToPage( int page );

protected:
    void Cancel();
    void Forward();
    void Backward();
    void MoveToPage( int page, int return_page = pgidEND );

    virtual void hideEvent(QHideEvent *e) override;
    virtual void showEvent(QShowEvent *e) override;

    SimpleLogger* Logger();

    void Log( const QString& log_line );

protected slots:
    void on_pushButton_forward_clicked();
    void on_pushButton_cancel_clicked();

private:
    /*
    Galim:
    Поменяем стартовую страницу
    */
    //PageIndexId mPageId = pgidSelectSession;
    PageIndexId mPageId = pgidStart;
    std::unique_ptr<SimpleLogger> mLogger;
};

void PopulatePages( QStackedWidget* stack_widget );

QString  PageNameFromId( PageIndexId id);

#endif // PAGE_UTILS_H
