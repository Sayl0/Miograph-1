#include "page_utils.h"

#include "startpage.h"
#include "selectuserpage.h"
#include "usersregistrationpage.h"
#include "showhelppage.h"
#include "modeselectionpage.h"
#include "passivemodesettingspage.h"
#include "passivemodestartpage.h"
#include "activepassivemodesettingspage.h"
#include "activepassivemodestartpage.h"
#include "activemodesettingspage.h"
#include "activemodestartpage.h"
#include "diagnosisanglepage.h"
#include "diagnosismaxstrengthpage.h"
#include "signalcalibrationpage.h"
#include "diagnosismaxstrengthcomppage.h"
#include "diagnosisanklemobstrpage.h"

#include "ex_passivepage.h"
#include "ex_activepassivepage.h"
#include "ex_activepage.h"
#include "ex_anklepassivepage.h"

#include "testing/cmiographtester.h"
#include "testing/ckardoigraphdataemulator.h"
#include "old_bl/ckardiographproxy.h"

#include "selectsessionlistpage.h"
#include "preparepatientskinpage.h"
#include "preparesensorspage.h"
#include "preparecomconnectionpage.h"
#include "testdevicemovementpage.h"
#include "testmiographconnectionpage.h"
#include "calibrartionpage.h"
#include "measureforcelevelpage.h"
#include "legbendmeasurepage.h"
#include "exerciseconfigpage.h"
#include "exercisepage.h"
#include "exercisereportshortpage.h"
#include "exercisereportfullpage.h"
#include "exercisepassivepage.h"
#include "activewithsensorspage.h"
#include "old_bl/cstreamcontrol.h"

#include <QDebug>

const quint8 DEFAULT_LEG_POS = 25;

QStack<PageIndexId> RETURN_PAGE_IDS;

BasePage::BasePage(PageIndexId page, QWidget *parent)
    :QWidget(parent)
    ,mPageId( page )
{
    connect( this, SIGNAL(SignalMoveToPage(int)), parent, SLOT(setCurrentIndex(int)) );
}

PageIndexId BasePage::Page() const
{
    return mPageId;
}

void BasePage::Cancel()
{
    if( !RETURN_PAGE_IDS.empty() )
    {
        MoveToPage( RETURN_PAGE_IDS.pop() );
    }
    else
        /*
         * Galim
         * Поменяли стартовую страницу
        */
        //MoveToPage( pgidSelectSession );
        MoveToPage( pgidStart );
}

void BasePage::Forward()
{
    if( !RETURN_PAGE_IDS.empty() )
    {
        MoveToPage( RETURN_PAGE_IDS.pop() );
    }
    else
        MoveToPage( static_cast<int>( mPageId ) + 1 );
}

void BasePage::Backward()
{
    if( !RETURN_PAGE_IDS.empty() )
    {
        MoveToPage( RETURN_PAGE_IDS.pop() );
    }
    else
        MoveToPage( static_cast<int>( mPageId ) - 1 );
}

void BasePage::MoveToPage(int page , int return_page /*= pgidEND*/ )
{

    int idx = static_cast<int>( page );
    if( idx >= 0 && idx < pgidEND )
    {
        Log( "Переход на страницу: " + PageNameFromId( static_cast<PageIndexId>(page) ) );
        emit SignalMoveToPage( page );
        if( return_page >= 0 && return_page < pgidEND )
        {
            RETURN_PAGE_IDS.push( static_cast<PageIndexId>( return_page ));
        }
    }
    else
        qDebug()<<"ERROR: page idx out of bounds ("<<page<<")";
}

void BasePage::hideEvent(QHideEvent* e)
{
    if( mLogger != nullptr )
        mLogger.reset( nullptr );
    MyParent::hideEvent( e );
}

void BasePage::showEvent(QShowEvent* e)
{
    if( mLogger == nullptr )
    {
        QString page_name = PageNameFromId( mPageId );
        mLogger = std::make_unique<SimpleLogger>( page_name, page_name );
    }
    MyParent::showEvent( e );
}

SimpleLogger *BasePage::Logger()
{
    return mLogger != nullptr ? mLogger.get() : nullptr;
}

void BasePage::Log(const QString &log_line)
{
    if( mLogger != nullptr )
        mLogger->Log( log_line );
}

void BasePage::on_pushButton_forward_clicked()
{
    Forward();
}

void BasePage::on_pushButton_cancel_clicked()
{
    Cancel();
}

void PopulatePages( QStackedWidget* stack_widget )
{
    if( stack_widget == nullptr )
        return;

    while( stack_widget->currentWidget() != nullptr )
        stack_widget->removeWidget( stack_widget->currentWidget() );

    stack_widget->addWidget( new StartPage( stack_widget ) );
    stack_widget->addWidget( new SelectUserPage( stack_widget ) );
    stack_widget->addWidget( new UsersRegistrationPage( stack_widget ) );
    stack_widget->addWidget( new ShowHelpPage( stack_widget ) );
    stack_widget->addWidget( new ModeSelectionPage( stack_widget ) );
    stack_widget->addWidget( new PassiveModeSettingsPage( stack_widget ) );
    stack_widget->addWidget( new PassiveModeStartPage( stack_widget ) );
    stack_widget->addWidget( new ActivePassiveModeSettingsPage( stack_widget ) );
    stack_widget->addWidget( new ActivePassiveModeStartPage( stack_widget ) );
    stack_widget->addWidget( new ActiveModeSettingsPage( stack_widget ) );
    stack_widget->addWidget( new ActiveModeStartPage( stack_widget ) );
    stack_widget->addWidget( new DiagnosisAnglePage( stack_widget ) );
    stack_widget->addWidget( new DiagnosisMaxStrengthPage( stack_widget ) );
    stack_widget->addWidget( new SignalCalibrationPage( stack_widget ) );
    stack_widget->addWidget( new DiagnosisMaxStrengthCompPage( stack_widget ) );
    stack_widget->addWidget( new DiagnosisAnkleMobStrPage( stack_widget ) );
    stack_widget->addWidget( new Ex_PassivePage( stack_widget ) );
    stack_widget->addWidget( new Ex_ActivePassivePage( stack_widget ) );
    stack_widget->addWidget( new Ex_ActivePage( stack_widget ) );
    stack_widget->addWidget( new Ex_AnklePassivePage( stack_widget ) );
    //Пока уберем, не получается так
    stack_widget->addWidget( new CMiographTester( stack_widget ) );
    //
    //stack_widget->addWidget( new SelectSessionListPage( stack_widget ) );
    //stack_widget->addWidget( new PreparePatientSkinPage( stack_widget ) );
    //stack_widget->addWidget( new PrepareSensorsPage( stack_widget ) );
    //stack_widget->addWidget( new PrepareComConnectionPage( stack_widget ) );
    //stack_widget->addWidget( new TestDeviceMovementPage( stack_widget ) );
    //stack_widget->addWidget( new TestMiographConnectionPage( stack_widget ) );
    stack_widget->addWidget( new CalibrartionPage( stack_widget ) );
    //stack_widget->addWidget( new MeasureForceLevelPage( stack_widget ) );
    stack_widget->addWidget( new LegBendMeasurePage( stack_widget ) );
    stack_widget->addWidget( new ExerciseConfigPage( stack_widget ) );
    stack_widget->addWidget( new ExercisePage( stack_widget ) );
    stack_widget->addWidget( new ExercisePassivePage( stack_widget ) );
    stack_widget->addWidget( new ActiveWithSensorsPage( stack_widget ) );
    //stack_widget->addWidget( new ExerciseReportShortPage( stack_widget ) );
    //stack_widget->addWidget( new ExerciseReportFullPage( stack_widget ) );
    /*
     * Galim:
     * Поменяли стартовую страницу
    */
    //stack_widget->setCurrentIndex( pgidSelectSession );
    stack_widget->setCurrentIndex( pgidStart );
}

quint16 AngleFromPos(quint16 pos)
{
    double c = 100.0 / 81;
    double angle = pos / c;
    return static_cast<quint16>( angle );
}

quint8 GetLevelFromStreamHandler(int stream_handler_idx)
{
    auto handler = CStreamControl::StreamHandlers[stream_handler_idx];
    double energy_level = handler->data->db_energy.first();
    //qDebug()<<"Energy level"<<energy_level;
    return static_cast<quint8>( energy_level / 10 );
}

QString PageNameFromId(PageIndexId id)
{
    switch (id) {
    /*
     * Galim
     * Поменяли стартовую страницу
   */
    //case pgidSelectSession:
    //    return "SelectSessionPage";
    case pgidStart:
        return "StartPage";
    case pgidSelectUser:
        return "SelectUserPage";
    case pgidUsersRegistration:
        return "UsersRegistration";
    case pgidShowHelp:
        return "ShowHelp";
    case pgidModeSelection:
        return "ModeSelection";
    case pgidPassiveModeSettings:
        return "PassiveModeSettings";
    case pgidPassiveModeStart:
        return "PassiveModeStart";
    case pgidActivePassiveModeSettings:
        return "ActivePassiveModeSettings";
    case pgidActivePassiveModeStart:
        return "ActivePassiveModeStart";
    case pgidActiveModeSettings:
        return "ActiveModeSettings";
    case pgidActiveModeStart:
        return "ActiveModeStart";
    case pgidDiagnosisAngle:
        return "DiagnosisAngle";
    case pgidDiagnosisMaxStrength:
        return "DiagnosisMaxStrength";
    case pgidSignalCalibration:
        return "SignalCalibration";
    case pgidDiagnosisMaxStrengthComp:
        return "DiagnosisMaxStrengthComp";
    case pgidDiagnosisAnkleMobStr:
        return "DiagnosisAnkleMobStr";
    case pgidEx_Passive:
        return "Ex_Passive";
    case pgidEx_ActivePassive:
        return "Ex_ActivePassive";
    case pgidEx_Active:
        return "Ex_Active";
    case pgidEx_AnklePassive:
        return "Ex_AnklePassive";
    case pgidCMiographTester:
        return "CMiographTester";
//
    case pgidSettingCalibration:
        return "SettingCalibration";
    case pgidSettingLegBend:
        return "SettingLegBend";
    case pgidExerciseConfig:
        return "ExerciseConfig";
    case pgidExercise:
        return "Exercise";
    }
    return "Unknown page id";
}
