#ifndef DIAGNOSISMAXSTRENGTHPAGE_H
#define DIAGNOSISMAXSTRENGTHPAGE_H

#include <QWidget>
#include "page_utils.h"

#include <QTime>
#include <QTimer>
#include <QProgressBar>
#include "old_bl/clogmanager.h"
#include "testing/ckardoigraphdataemulator.h"
#include "old_bl/ckardiographproxy.h"
#include "QLabel"
#include "QCheckBox"

#include <QMessageBox>


namespace Ui {
class DiagnosisMaxStrengthPage;
}

// Forward declaration
class QCPGraph;

using TesterDataType = QVector<double>;


class DiagnosisMaxStrengthPage : public BasePage
{
    using MyParent = BasePage;
    Q_OBJECT

public:
    explicit DiagnosisMaxStrengthPage(CKardiographProxy* kardograph_proxy, bool is_connected, CKardiographDataEmulator* emulator = nullptr, QWidget *parent = nullptr);
    DiagnosisMaxStrengthPage( QWidget *parent);
    ~DiagnosisMaxStrengthPage();

    static const int CHANNELS_COUNT = 2;

    virtual void showEvent(QShowEvent *e) override;

signals:
    void SetKardiographPtr( CKardiographHelper* ptr );
    void SetKardiographProxyPtr( CKardiographProxy* ptr );
    void OpenLog( QString log_folder );
    void CloseLog();

    void SetFilterWindowWidth( int width );
    void SetMedianFilterSize( int width );

    void ReadFile( QString file_name );

private slots:
    // Kardiograph slots:

    void OnKardiographConnected ( bool connected );
    void OnErrorUDP( QString error_str );
    void OnWarningUDP( QString warning_str );

    void OnSignalOutFilterCh1( double re, double im, double amp, QTime time );
    void OnSignalOutFilterCh2( double re, double im, double amp, QTime time );
    void OnSignalOutFilterCh3( double re, double im, double amp, QTime time );
    void OnSignalOutFilterCh4( double re, double im, double amp, QTime time );

    void OnSignalAmpCh1( double amp, QTime time );
    void OnSignalAmpCh2( double amp, QTime time );
    void OnSignalAmpCh3( double amp, QTime time );
    void OnSignalAmpCh4( double amp, QTime time );

    void OnSignalRawDataCh1( QVector<double> vector_ch1 );
    void OnSignalRawDataCh2( QVector<double> vector_ch2 );

    // Timer slots:
    void OnReplotTimer(); /**< Graph replotting 50 gz */

    // Interface slots:

    //void on_pushButton_cancel_clicked();

    void on_pushButton_exercise_clicked();

    void on_pushButtonAmpSpectre_clicked();

    //void on_pushButton_registr_ext_clicked();

    //void on_pushButton_registr_curl_clicked();
    void ButtonToggledExt(bool state);
    void ButtonToggledCurl(bool state);

private:
    // Channels input data collection
    struct InputDataCollection
    {
        const int constMax_data_count = 4000;
        TesterDataType time_filter_amp[CHANNELS_COUNT];
        TesterDataType filter_amp[CHANNELS_COUNT];

        TesterDataType time_amp[CHANNELS_COUNT];
        TesterDataType amp[CHANNELS_COUNT];

        InputDataCollection()
        {
            for( int i = 0; i < CHANNELS_COUNT; ++i )
            {
                time_filter_amp[i].reserve( constMax_data_count + 1 );
                filter_amp[i].reserve( constMax_data_count + 1 );
                time_amp[i].reserve( constMax_data_count + 1 );
                amp[i].reserve( constMax_data_count + 1 );
            }
        }

        void Clear()
        {
            for( int i = 0; i < CHANNELS_COUNT; ++i )
            {
                time_filter_amp[i].clear();
                filter_amp[i].clear();
                time_amp[i].clear();
                amp[i].clear();
            }
        }
    }mInputData;


    Ui::DiagnosisMaxStrengthPage *ui;
    CKardiographHelper* mKardiograph = nullptr;
    bool mIsConnected = false;

    void AddStrToLog( const QString& str );
    QTime mStartTime;
    double TimeSinceStart( QTime time );
    void AddTimeAndAmp(TesterDataType& time_v, TesterDataType& amp_v, double amp , QTime time);

    QTimer mReplotTimer;

    void  InitChannelsVisualElements();

    void AssignControls();

    // all visual elements involved in channel data visualisation
    struct ChannelRelatedVisualElements
    {
        QCPGraph* graph = nullptr;
        QCheckBox* show_checkbox = nullptr;
        QProgressBar* progressbar = nullptr;
        QLabel* data_label = nullptr;

        void CheckGraphVisibility();
    }mChannelElem[CHANNELS_COUNT];

    CLogManager mLogManager;

    // Proxy filter
    CKardiographProxy* mKardiographProxy;

    QVector<double> mVectorCh1;
    QVector<double> mVectorCh2;
    QVector<double> mFreqVector;
    double mMaxEnergy[2];

    QCPGraph* mGraph1 = nullptr;
    QCPGraph* mGraph2 = nullptr;

    void SetDLgConnectedState( bool connected );

    //Пропавшие элементы)
    int filter_decimation_value = 1;
    int filter_median_value = 11;
    int horizontalSlider_timescale_value = 10;

    bool mIsAmplitudeChecked = false;
    bool mIsSpecterChecked = true;

    double maxPowExtChannel = 200;
    double maxPowCurlChannel = 200;
    double  fullPowExt = 400;
    double  fullPowCurl = 400;
public:
    qreal getMaxPowerExt();
    qreal getMaxPowerCurl();
    double getPowerPoints(double power, double fullPower);
    double getPowerPercentExt(double power);
    double getPowerPercentCurl(double power);
};

#endif // DIAGNOSISMAXSTRENGTHPAGE_H
