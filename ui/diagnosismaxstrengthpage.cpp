#include "diagnosismaxstrengthpage.h"
#include "ui_diagnosismaxstrengthpage.h"

#include "QSettings"
#include "blglue.h"
#include "old_bl/cstreamcontrol.h"

#include "algorithm"


DiagnosisMaxStrengthPage::DiagnosisMaxStrengthPage(CKardiographProxy *kardograph_proxy, bool is_connected, CKardiographDataEmulator *emulator, QWidget *parent /*= nullptr*/) :
    BasePage(pgidCMiographTester, parent),
    ui(new Ui::DiagnosisMaxStrengthPage),
    mIsConnected( is_connected ),
    mKardiographProxy(kardograph_proxy)

{
    ui->setupUi(this);
    // connect buttons init
    //ui->pushButton_connection_on->setEnabled(!mIsConnected);
    //ui->pushButton_connection_off->setEnabled(mIsConnected);
    //Galim:
    //И этого теперь нет:
    //ui->pushButtonAmpSpectre->setChecked(false);
    //mIsAmplitudeChecked = false;

    // Graph
    InitChannelsVisualElements();

    // timers configuration
    connect( &mReplotTimer, SIGNAL(timeout()), this, SLOT(OnReplotTimer()) );
    mReplotTimer.start(35);

    connect( this, SIGNAL( SetFilterWindowWidth( int ) ), mKardiographProxy, SLOT( SetFilterWidth( int ) ));
    connect( this, SIGNAL( SetMedianFilterSize( int) ), mKardiographProxy, SLOT( SetMedianFilterWidth( int) ));


    if( mKardiograph == nullptr )
        mKardiograph = mKardiographProxy->GetGLobalKardiographPtr();

    connect( this, SIGNAL(SetKardiographProxyPtr(CKardiographProxy*)),emulator, SLOT( SetKardiographProxyPtr(CKardiographProxy*) ));
    connect( this, SIGNAL(OpenLog(QString)), emulator, SLOT( OpenLogFolder(QString)) );
    connect( this, SIGNAL(CloseLog()),emulator, SLOT( CloseLogFolder()) );

    emit SetKardiographProxyPtr(mKardiographProxy);

    //Galim:
    //Вместо выкинутых спинбоксов:
    emit SetFilterWindowWidth(filter_decimation_value);
    emit SetMedianFilterSize(filter_median_value);
    //emit SetFilterWindowWidth(ui->spinBox_filter_decimation->value());
    //emit SetMedianFilterSize( ui->spinBox_filter_median->value() );

    // kardiograph connection section
    connect( mKardiographProxy, SIGNAL(connectedUDP(bool)), this, SLOT(OnKardiographConnected(bool) ) );
    connect( mKardiographProxy, SIGNAL(errorUDP(QString)), this, SLOT(OnErrorUDP(QString) ) );
    connect( mKardiographProxy, SIGNAL(warningUDP(QString)), this, SLOT(OnWarningUDP(QString) ) );

    connect( mKardiographProxy, SIGNAL(signal_out_filter_ch1(double, double, double, QTime)), this, SLOT(OnSignalOutFilterCh1(double, double, double, QTime) ) );
    connect( mKardiographProxy, SIGNAL(signal_out_filter_ch2(double, double, double, QTime)), this, SLOT(OnSignalOutFilterCh2(double, double, double, QTime) ) );
    connect( mKardiographProxy, SIGNAL(signal_out_filter_ch3(double, double, double, QTime)), this, SLOT(OnSignalOutFilterCh3(double, double, double, QTime) ) );
    connect( mKardiographProxy, SIGNAL(signal_out_filter_ch4(double, double, double, QTime)), this, SLOT(OnSignalOutFilterCh4(double, double, double, QTime) ) );

    connect( mKardiographProxy, SIGNAL(signal_amplitude_ch1(double, QTime)), this, SLOT(OnSignalAmpCh1(double, QTime) ) );
    connect( mKardiographProxy, SIGNAL(signal_amplitude_ch2(double, QTime)), this, SLOT(OnSignalAmpCh2(double, QTime) ) );
    connect( mKardiographProxy, SIGNAL(signal_amplitude_ch3(double, QTime)), this, SLOT(OnSignalAmpCh3(double, QTime) ) );
    connect( mKardiographProxy, SIGNAL(signal_amplitude_ch4(double, QTime)), this, SLOT(OnSignalAmpCh4(double, QTime) ) );

    connect( mKardiographProxy, SIGNAL(signal_raw_ch1(QVector<double>)), this, SLOT(OnSignalRawDataCh1(QVector<double>) ) );
    connect( mKardiographProxy, SIGNAL(signal_raw_ch2(QVector<double>)), this, SLOT(OnSignalRawDataCh2(QVector<double>) ) );




    // log configuration
    /*QString test_log_dir = "KardiographLog";
    CLoggerBase* p = nullptr;
    p = mLogManager.InsertLogger<CKardiographChannelLogger>( test_log_dir, QString() ,"out_filter_ch1" );
    connect( mKardiographProxy, SIGNAL(signal_raw_out_filter_ch1(double, double, double, QTime)), p, SLOT(OnSignalOutFilter(double, double, double, QTime) ) );
    p = mLogManager.InsertLogger<CKardiographChannelLogger>( test_log_dir, QString() ,"out_filter_ch2" );
    connect( mKardiographProxy, SIGNAL(signal_raw_out_filter_ch2(double, double, double, QTime)), p, SLOT(OnSignalOutFilter(double, double, double, QTime) ) );
    p = mLogManager.InsertLogger<CKardiographChannelLogger>( test_log_dir, QString() ,"out_filter_ch3" );
    connect( mKardiographProxy, SIGNAL(signal_raw_out_filter_ch3(double, double, double, QTime)), p, SLOT(OnSignalOutFilter(double, double, double, QTime) ) );
    p = mLogManager.InsertLogger<CKardiographChannelLogger>( test_log_dir, QString() ,"out_filter_ch4" );
    connect( mKardiographProxy, SIGNAL(signal_raw_out_filter_ch4(double, double, double, QTime)), p, SLOT(OnSignalOutFilter(double, double, double, QTime) ) );

    p = mLogManager.InsertLogger<CKardiographChannelLogger>( test_log_dir, QString() ,"amplitude_ch1" );
    connect( mKardiographProxy, SIGNAL(signal_raw_amplitude_ch1(double, QTime)), p, SLOT(OnSignalAmp(double, QTime) ) );
    p = mLogManager.InsertLogger<CKardiographChannelLogger>( test_log_dir, QString() ,"amplitude_ch2" );
    connect( mKardiographProxy, SIGNAL(signal_raw_amplitude_ch2(double, QTime)), p, SLOT(OnSignalAmp(double, QTime) ) );
    p = mLogManager.InsertLogger<CKardiographChannelLogger>( test_log_dir, QString() ,"amplitude_ch3" );
    connect( mKardiographProxy, SIGNAL(signal_raw_amplitude_ch3(double, QTime)), p, SLOT(OnSignalAmp(double, QTime) ) );
    p = mLogManager.InsertLogger<CKardiographChannelLogger>( test_log_dir, QString() ,"amplitude_ch4" );
    connect( mKardiographProxy, SIGNAL(signal_raw_amplitude_ch4(double, QTime)), p, SLOT(OnSignalAmp(double, QTime) ) );

    mLogManager.StartThread();*/

    //ui->checkBox_write_file_kardio_lib->setChecked( mKardiograph->enableWriteData );
    mFreqVector = {60,63, 66, 70, 73, 77, 81, 85, 90, 94, 99, 104, 110, 115, 121, 128, 134, 141, 148, 156, 164, 172, 181, 191, 200, 211, 222, 233, 245, 258, 271, 285};
    qDebug()<<"mFreqVector size:"<<mFreqVector.size();

    //Galim:
    //Достаем значения макс.силы для каналов
    QSettings settings("MaxPow.ini", QSettings::IniFormat);

    if (!settings.contains("MaxPow/ExtChannel")) settings.setValue("MaxPow/ExtChannel", qreal( maxPowExtChannel ));
    else maxPowExtChannel = settings.value("MaxPow/ExtChannel").toReal();
    if (!settings.contains("MaxPow/CurlChannel")) settings.setValue("MaxPow/CurlChannel", qreal( maxPowCurlChannel ));
    else maxPowCurlChannel = settings.value("MaxPow/CurlChannel").toReal();

    // FullPow - всегда 400
    if (settings.contains("FullPow/ExtChannel"))
        fullPowExt = settings.value("FullPow/ExtChannel").toReal();
    else
        settings.setValue("FullPow/ExtChannel", 400.0);
    if (settings.contains("FullPow/CurlChannel"))
        fullPowCurl = settings.value("FullPow/CurlChannel").toReal();
    else
        settings.setValue("FullPow/CurlChannel", 400.0);
    //ui->lineEdit_ext->setText(QString::number(maxPowExtChannel, 'f', 1));
    //ui->lineEdit_curl->setText(QString::number(maxPowCurlChannel, 'f', 1));
    // Теперь там будут баллы:
    ui->lineEdit_ext->setText(QString::number(getPowerPoints(maxPowExtChannel,fullPowExt), 'f', 1));
    ui->lineEdit_curl->setText(QString::number(getPowerPoints(maxPowCurlChannel,fullPowCurl), 'f', 1));

    connect(ui->pushButton_registr_ext, SIGNAL(toggled(bool)), this, SLOT(ButtonToggledExt(bool)));
    connect(ui->pushButton_registr_curl, SIGNAL(toggled(bool)), this, SLOT(ButtonToggledCurl(bool)));
}

DiagnosisMaxStrengthPage::DiagnosisMaxStrengthPage( QWidget *parent):
    DiagnosisMaxStrengthPage(&BlGlue::Instance().mKardiographProxy,false,&BlGlue::Instance().mDataEmulator, parent)
{
}

DiagnosisMaxStrengthPage::~DiagnosisMaxStrengthPage()
{
    delete ui;
}



void DiagnosisMaxStrengthPage::showEvent(QShowEvent* e)
{
    if( mKardiographProxy != nullptr )
        return;
    SetDLgConnectedState( mKardiographProxy->IsConnected() );
    //Galim:
    //Что тут делать, непонятно пока
    //QDialog::showEvent(e);
}

void DiagnosisMaxStrengthPage::OnKardiographConnected(bool connected)
{
    SetDLgConnectedState(connected);
    Log( mIsConnected ? "Connected" : "Disconnected" );
    Log("\r\n");
}

void DiagnosisMaxStrengthPage::OnErrorUDP(QString error_str)
{
    Log( "Error: " );
    Log( error_str );
    Log("\r\n");
}

void DiagnosisMaxStrengthPage::OnWarningUDP(QString warning_str)
{
    Log( "Warning: " );
    Log( warning_str );
    Log("\r\n");
}


void DiagnosisMaxStrengthPage::AddTimeAndAmp(TesterDataType &time_v, TesterDataType &amp_v, double amp, QTime time)
{
    if( mStartTime.isNull())
        mStartTime = time;

    time_v.push_front(TimeSinceStart(time));
    amp_v.push_front( amp );

    if( time_v.size() > mInputData.constMax_data_count )
    {
        time_v.removeLast();
        amp_v.removeLast();
    }
}


void DiagnosisMaxStrengthPage::InitChannelsVisualElements()
{
    AssignControls();

    // graph init
    QVector<QColor> colors_vect =
    {
        QColor( 249, 30, 0 ), // orange
        Qt::blue,
        QColor( 153, 102, 204 ), //amethyst
        Qt::green,
        Qt::black,
        Qt::cyan,
        Qt::magenta,
        Qt::darkGray,
        Qt::darkGreen
    };

    /*for( int i = 0; i < CHANNELS_COUNT; ++i )
    {
        auto p = ui->plot_data->addGraph();
        mChannelElem[i].graph = p;
        p->setName( QString( "Канал №" ) + QString::number( i + 1 ) );

        auto& color = colors_vect[i];
        p->setPen( QPen( color, 3));
        color.setAlpha(0);
        p->setBrush(QBrush(color));
    }
    ui->plot_data->legend->setVisible(true);
    //ui->plot_data->setOpenGl( true );
    qDebug()<<"OGL"<<ui->plot_data->openGl();*/

    mGraph1 = ui->plot_data_2->addGraph();
    mChannelElem[0].graph = mGraph1;
    // Никита:
    // Переименовать каналы в "Сгибатели", "Разгибатели"
    // mGraph1->setName( "Канал №1" );
    mGraph1->setName( "Разгибатели" );
    auto& color = colors_vect[0];
    mGraph1->setPen( QPen( color, 3));
    color.setAlpha(0);
    mGraph1->setBrush(QBrush(color));

    mGraph2 = ui->plot_data_2->addGraph();
    mChannelElem[1].graph = mGraph2;
    //mGraph2->setName( "Канал №2" );
    mGraph2->setName( "Сгибатели" );
    color = colors_vect[1];
    mGraph2->setPen( QPen( color, 3));
    color.setAlpha(0);
    mGraph2->setBrush(QBrush(color));

    ui->plot_data_2->legend->setVisible(true);
}


void DiagnosisMaxStrengthPage::AssignControls()
{
    //mChannelElem[0].show_checkbox = ui->checkBox_channel1;
    //Galim:
    //mChannelElem[0].data_label = ui->label_K1;
    //mChannelElem[0].progressbar = ui->progressBar_K1;

    //mChannelElem[1].show_checkbox = ui->checkBox_channel2;
    //Galim:
    //mChannelElem[1].data_label = ui->label_K2;
    //mChannelElem[1].progressbar = ui->progressBar_K2;
    //это уже до меня выкинули:
    /*mChannelElem[2].show_checkbox = ui->checkBox_channel3;
    mChannelElem[2].data_label = ui->label_K3;
    mChannelElem[2].progressbar = ui->progressBar_K3;

    mChannelElem[3].show_checkbox = ui->checkBox_channel4;
    mChannelElem[3].data_label = ui->label_K4;
    mChannelElem[3].progressbar = ui->progressBar_K4;*/
}


void DiagnosisMaxStrengthPage::SetDLgConnectedState(bool connected)
{
    mIsConnected = connected;
    //Galim:
    //Их больше нет:
    //ui->pushButton_connection_on->setEnabled(!mIsConnected);
    //ui->pushButton_connection_off->setEnabled(mIsConnected);

    if( connected )
    {
        mInputData.Clear();
        mKardiographProxy->ClearFilters();
    }
}

double CalcEnergyMM( double re, double im, double amp )
{
    return sqrt( pow( re, 2 ) + pow( im , 2 ) )/amp;
}

void DiagnosisMaxStrengthPage::OnSignalOutFilterCh1(double re, double im, double amp, QTime time)
{
    int ch = 0;
    AddTimeAndAmp( mInputData.time_filter_amp[ch], mInputData.filter_amp[ch], CalcEnergyMM( re, im, amp ), time );
}

void DiagnosisMaxStrengthPage::OnSignalOutFilterCh2(double re, double im, double amp, QTime time)
{
    int ch = 1;
    AddTimeAndAmp( mInputData.time_filter_amp[ch], mInputData.filter_amp[ch], CalcEnergyMM( re, im, amp ), time );
}

void DiagnosisMaxStrengthPage::OnSignalOutFilterCh3(double re, double im, double amp, QTime time)
{
    int ch = 2;
    AddTimeAndAmp( mInputData.time_filter_amp[ch], mInputData.filter_amp[ch], CalcEnergyMM( re, im, amp ), time );
}

void DiagnosisMaxStrengthPage::OnSignalOutFilterCh4(double re, double im, double amp, QTime time)
{
    int ch = 3;
    AddTimeAndAmp( mInputData.time_filter_amp[ch], mInputData.filter_amp[ch], CalcEnergyMM( re, im, amp ), time );
}

void DiagnosisMaxStrengthPage::OnSignalAmpCh1(double amp , QTime time)
{
    int ch = 0;
    AddTimeAndAmp( mInputData.time_amp[ch], mInputData.amp[ch], amp, time );
}

void DiagnosisMaxStrengthPage::OnSignalAmpCh2(double amp, QTime time)
{
    int ch = 1;
    AddTimeAndAmp( mInputData.time_amp[ch], mInputData.amp[ch], amp, time );
}

void DiagnosisMaxStrengthPage::OnSignalAmpCh3(double amp, QTime time)
{
    int ch = 2;
    AddTimeAndAmp( mInputData.time_amp[ch], mInputData.amp[ch], amp, time );
}

void DiagnosisMaxStrengthPage::OnSignalAmpCh4(double amp, QTime time)
{
    int ch = 3;
    AddTimeAndAmp( mInputData.time_amp[ch], mInputData.amp[ch], amp, time );
}

void DiagnosisMaxStrengthPage::OnSignalRawDataCh1(QVector<double> vector_ch1)
{
    mVectorCh1 = std::move( vector_ch1 );
}

void DiagnosisMaxStrengthPage::OnSignalRawDataCh2(QVector<double> vector_ch2)
{
    mVectorCh2 = std::move( vector_ch2 );
}

double CurrentAMP_MM( const TesterDataType& amp )
{
    return amp.empty() ? 0.0 : amp.first();
}


QString CurrentAMPString_MM( int ch_num, int percent_amp )
{
    return QString( "K" ) +
            QString::number( ch_num + 1 ) +
            "(" + QString::number(percent_amp) + "%)";
}

TesterDataType TrimmedTimeVector_MM( int& trim_size, const TesterDataType& time, double sz )
{
    if( time.empty() )
        return time;

    trim_size = time.size();
    double max_value = time.first();
    double min_value = time.last();
    if( (max_value - min_value) > sz )
    {
        min_value = max_value - sz;
        int i = time.size() - 1;
        for( ; i > 0; --i )
        {
            if( time[i] > min_value )
            {
                trim_size = i+1;
                return time.mid( 0, trim_size );
            }
        }
    }
    return time;
}



qreal DiagnosisMaxStrengthPage::getMaxPowerExt()
{
    return maxPowExtChannel;
}

qreal DiagnosisMaxStrengthPage::getMaxPowerCurl()
{
    return maxPowCurlChannel;
}

/**
 * Функция, возвращающая баллы вместо значений силы
 * Никита:
 * Х=регистрируемое макс  значение по каналу (то, что сейчас выводим в окно)*100/full pow - это значение в %
 * Galim:
 * Если хотим баллы до 5, лучше сразу умножить на 5, и не париться
 *
 * @brief DiagnosisMaxStrengthPage::getPowerPercent
 * @param power
 * @param fullPower
 * @return баллы до 5
 */
double DiagnosisMaxStrengthPage::getPowerPoints(double power, double fullPower)
{
    double points = power*5/fullPower;
    if (points>5) points=5.0;
    return points;
}

/**
 * Функция, возвращающая проценты вместо значений силы
 * Никита:
 * Х=регистрируемое макс  значение по каналу (то, что сейчас выводим в окно)*100/full pow - это значение в %
 * @brief DiagnosisMaxStrengthPage::getPowerPercentExt
 * @param power
 * @return проценты вместо значений
 */
double DiagnosisMaxStrengthPage::getPowerPercentExt(double power)
{
    return power*100/fullPowExt;
}
/**
 * Функция, возвращающая проценты вместо значений силы
 * Никита:
 * Х=регистрируемое макс  значение по каналу (то, что сейчас выводим в окно)*100/full pow - это значение в %
 * @brief DiagnosisMaxStrengthPage::getPowerPercentCurl
 * @param power
 * @return проценты вместо значений
 */
double DiagnosisMaxStrengthPage::getPowerPercentCurl(double power)
{
    return power*100/fullPowCurl;
}
/*
 *

void CMiographTester::on_pushButton_connection_on_clicked()
{
    AddStrToLog("Attempt to connect... \r\n");
    CKardiographProxy::Connect( true );
    OnKardiographConnected( true );
}

void CMiographTester::on_pushButton_connection_off_clicked()
{
    AddStrToLog("Disconnecting... \r\n");
    CKardiographProxy::Connect( false );
}
*/

/*
void CMiographTester::AddStrToLog(const QString &str)
{
    QTextCursor text_cursor = QTextCursor(ui->textEdit_connection_log->document());
    text_cursor.movePosition(QTextCursor::End);
    text_cursor.insertText( str );
    text_cursor.movePosition(QTextCursor::End);
}
*/


const int constMSecsInDay = QTime( 23,59,59,999 ).msecsSinceStartOfDay() + 1;

QTime MinusTimeMM( QTime first, QTime second )
{
    int res_msec = first.msecsSinceStartOfDay() - second.msecsSinceStartOfDay();
    if( res_msec < 0 )
        res_msec += constMSecsInDay;
    return QTime::fromMSecsSinceStartOfDay( res_msec );
}

double DiagnosisMaxStrengthPage::TimeSinceStart(QTime time)
{
    QTime diff_time = MinusTimeMM( time, mStartTime );
    ////qDebug()<<"Diff"<<time<<mStartTime<<diff_time;
    return double(diff_time.msecsSinceStartOfDay())/1000;
}

void DiagnosisMaxStrengthPage::ChannelRelatedVisualElements::CheckGraphVisibility()
{
    if( show_checkbox == nullptr || graph == nullptr )
        return;

    if( show_checkbox->isChecked() != graph->visible() )
    {
        graph->setVisible(show_checkbox->isChecked());
    }
}

/*
void DiagnosisMaxStrengthPage::on_pushButton_cancel_clicked()
{
    MoveToPage(pgidEx_Active);
}
*/

void DiagnosisMaxStrengthPage::on_pushButton_exercise_clicked()
{
    MoveToPage(pgidActiveModeSettings);
}


void DiagnosisMaxStrengthPage::on_pushButtonAmpSpectre_clicked()
{
    if(ui->pushButtonAmpSpectre->isChecked())
    {
        mIsAmplitudeChecked = true;
        mIsSpecterChecked = false;
        qDebug()<<"pushButtonAmpSpectre is checked!";
    }
    else
    {
        mIsAmplitudeChecked = false;
        mIsSpecterChecked = true;
        qDebug()<<"pushButtonAmpSpectre is not checked!";
    }
}

void DiagnosisMaxStrengthPage::OnReplotTimer()
{
    if( !isVisible() )
        return;
    //Galim:
    //Замена radioButton QPushButton
    //if( !ui->radioButton_specter->isChecked() )
    //qDebug()<<"mIsAmplitudeChecked:"<<mIsAmplitudeChecked;
    if( !mIsSpecterChecked )
    {
        //bool use_db_data = ui->radioButton_db->isChecked();
        //bool use_db_data = mIsAmplitudeChecked;
        //Если ее просто убрали, наверное, true:
        bool use_db_data = true;
        double channel_sum = 0.0;
        for( int i = 0; i < CHANNELS_COUNT; ++i )
        {
            auto& amp =  mInputData.amp[i];
            channel_sum += CurrentAMP_MM( amp );
        }
        //double x_min = 10000000.0, x_max = 0.0;
        for( int i = 0; i < CHANNELS_COUNT; ++i )
        {
            auto& hdl = CStreamControl::StreamHandlers[i];
            auto& time = mInputData.time_amp[i];
            auto& amp = use_db_data ? hdl->data->db_energy : mInputData.amp[i];

            auto& controls = mChannelElem[i];
            if( !use_db_data )
            {
                int percent_amp = static_cast<int>(channel_sum != 0.0 ? ( CurrentAMP_MM(amp) * 100.0 / channel_sum ) : 0);
                controls.data_label->setText( CurrentAMPString_MM( i, percent_amp ) );
                if( controls.progressbar != nullptr )
                {
                    controls.progressbar->setValue( percent_amp );
                    controls.progressbar->repaint();
                }
            }
            // graph
            controls.CheckGraphVisibility();
            if( controls.graph->visible() )
            {
                int trim_size = 0;
                // Galim:
                // нет у нас больше этого слайдера:
                // horizontalSlider_timescale_value
                //auto time_trimmed = TrimmedTimeVector( trim_size, time, ui->horizontalSlider_timescale->value() );
                auto time_trimmed = TrimmedTimeVector_MM( trim_size, time, horizontalSlider_timescale_value );
                auto amp_trimmed = amp.mid(0, trim_size);
                // Galim:
                // Влепим пока сюда такой костыль, в векторе amp_trimmed найдем максимальный элемент, и  если он будет больше
                // соответствующего значения maxPowExtChannel или maxPowCurlChannel, то это теперь будет max значение
                //
                mMaxEnergy[i]=*std::max_element(amp_trimmed.begin(),amp_trimmed.end());
                controls.graph->setData( time_trimmed, amp_trimmed);
            }
        }
        // Galim:
        // здесь проверяем
        /*
         *
         * Никита: менять значения только при нажатой кнопки "Регистрация"
        if(mMaxEnergy[0]>maxPowExtChannel)
        {
        //ui->lineEdit_ext->setText(QString::number(mMaxEnergy[0]));
        // выводим теперь баллы вместо значений:
        double me0 = getPowerPoints(mMaxEnergy[0], fullPowExt);
        ui->lineEdit_ext->setText(QString::number(me0,'f',1));
        maxPowExtChannel = mMaxEnergy[0];
        }
        if(mMaxEnergy[1]>maxPowCurlChannel)
        {
        //ui->lineEdit_curl->setText(QString::number(mMaxEnergy[1]));
        // выводим теперь баллы вместо значений:
        double me1 = getPowerPoints(mMaxEnergy[1], fullPowCurl);
        ui->lineEdit_ext->setText(QString::number(me1,'f',1));
        maxPowCurlChannel = mMaxEnergy[1];
        }
        */
        ui->plot_data_2->yAxis->rescale(true);
        ui->plot_data_2->xAxis->rescale(true);

        ui->plot_data_2->replot();
        return;
    }
    //----------------------------------
    if( mFreqVector.size() != mVectorCh1.size() || mFreqVector.size() != mVectorCh2.size() )
        return;
    mGraph1->setVisible( true );
    mGraph1->setData( mFreqVector, mVectorCh1 );
    //qDebug()<<mVectorCh1;
    mGraph2->setVisible( true );
    mGraph2->setData( mFreqVector, mVectorCh2 );

    ui->plot_data_2->yAxis->rescale(true);
    ui->plot_data_2->xAxis->rescale(true);

    ui->plot_data_2->replot();

}

void DiagnosisMaxStrengthPage::ButtonToggledExt(bool state)
{
    if(state){//Кнопка зажата
        //ui->pushButton_registr_ext->setStyleSheet("color:green");
        if( !mIsSpecterChecked )
        {
            bool use_db_data = true;
            double channel_sum = 0.0;
            for( int i = 0; i < CHANNELS_COUNT; ++i )
            {
                auto& amp =  mInputData.amp[i];
                channel_sum += CurrentAMP_MM( amp );
            }
            //double x_min = 10000000.0, x_max = 0.0;
            for( int i = 0; i < CHANNELS_COUNT; ++i )
            {
                auto& hdl = CStreamControl::StreamHandlers[i];
                auto& time = mInputData.time_amp[i];
                auto& amp = use_db_data ? hdl->data->db_energy : mInputData.amp[i];

                auto& controls = mChannelElem[i];
                if( !use_db_data )
                {
                    int percent_amp = static_cast<int>(channel_sum != 0.0 ? ( CurrentAMP_MM(amp) * 100.0 / channel_sum ) : 0);
                    controls.data_label->setText( CurrentAMPString_MM( i, percent_amp ) );
                    if( controls.progressbar != nullptr )
                    {
                        controls.progressbar->setValue( percent_amp );
                        controls.progressbar->repaint();
                    }
                }
                // graph
                controls.CheckGraphVisibility();
                if( controls.graph->visible() )
                {
                    int trim_size = 0;
                    // Galim:
                    // нет у нас больше этого слайдера:
                    // horizontalSlider_timescale_value
                    //auto time_trimmed = TrimmedTimeVector( trim_size, time, ui->horizontalSlider_timescale->value() );
                    auto time_trimmed = TrimmedTimeVector_MM( trim_size, time, horizontalSlider_timescale_value );
                    auto amp_trimmed = amp.mid(0, trim_size);
                    // Galim:
                    // Влепим пока сюда такой костыль, в векторе amp_trimmed найдем максимальный элемент, и  если он будет больше
                    // соответствующего значения maxPowExtChannel или maxPowCurlChannel, то это теперь будет max значение
                    //
                    mMaxEnergy[i]=*std::max_element(amp_trimmed.begin(),amp_trimmed.end());
                    controls.graph->setData( time_trimmed, amp_trimmed);
                }
            }
            // Galim:
            // здесь проверяем
            /*
             *
             * Никита: менять значения только при нажатой кнопки "Регистрация"
            */
            if(mMaxEnergy[0]>maxPowExtChannel)
            {
                //ui->lineEdit_ext->setText(QString::number(mMaxEnergy[0]));
                // выводим теперь баллы вместо значений:
                double me0 = getPowerPoints(mMaxEnergy[0], fullPowExt);
                ui->lineEdit_ext->setText(QString::number(me0,'f',1));
                maxPowExtChannel = mMaxEnergy[0];
            }

            /*
            if(mMaxEnergy[1]>maxPowCurlChannel)
            {
            //ui->lineEdit_curl->setText(QString::number(mMaxEnergy[1]));
            // выводим теперь баллы вместо значений:
            double me1 = getPowerPoints(mMaxEnergy[1], fullPowCurl);
            ui->lineEdit_ext->setText(QString::number(me1,'f',1));
            maxPowCurlChannel = mMaxEnergy[1];
            }
            */
            return;
        }
        //---------------------------------
    }


    else{
        //Кнопка отжата

    }
}


void DiagnosisMaxStrengthPage::ButtonToggledCurl(bool state)
{
    if(state){//Кнопка зажата
        //ui->pushButton_registr_curl->setStyleSheet("color:green");
        if( !mIsSpecterChecked )
        {
            //bool use_db_data = ui->radioButton_db->isChecked();
            //bool use_db_data = mIsAmplitudeChecked;
            //Если ее просто убрали, наверное, true:
            bool use_db_data = true;
            double channel_sum = 0.0;
            for( int i = 0; i < CHANNELS_COUNT; ++i )
            {
                auto& amp =  mInputData.amp[i];
                channel_sum += CurrentAMP_MM( amp );
            }
            //double x_min = 10000000.0, x_max = 0.0;
            for( int i = 0; i < CHANNELS_COUNT; ++i )
            {
                auto& hdl = CStreamControl::StreamHandlers[i];
                auto& time = mInputData.time_amp[i];
                auto& amp = use_db_data ? hdl->data->db_energy : mInputData.amp[i];

                auto& controls = mChannelElem[i];
                if( !use_db_data )
                {
                    int percent_amp = static_cast<int>(channel_sum != 0.0 ? ( CurrentAMP_MM(amp) * 100.0 / channel_sum ) : 0);
                    controls.data_label->setText( CurrentAMPString_MM( i, percent_amp ) );
                    if( controls.progressbar != nullptr )
                    {
                        controls.progressbar->setValue( percent_amp );
                        controls.progressbar->repaint();
                    }
                }
                // graph
                controls.CheckGraphVisibility();
                if( controls.graph->visible() )
                {
                    int trim_size = 0;
                    // Galim:
                    // нет у нас больше этого слайдера:
                    // horizontalSlider_timescale_value
                    //auto time_trimmed = TrimmedTimeVector( trim_size, time, ui->horizontalSlider_timescale->value() );
                    auto time_trimmed = TrimmedTimeVector_MM( trim_size, time, horizontalSlider_timescale_value );
                    auto amp_trimmed = amp.mid(0, trim_size);
                    // Galim:
                    // Влепим пока сюда такой костыль, в векторе amp_trimmed найдем максимальный элемент, и  если он будет больше
                    // соответствующего значения maxPowExtChannel или maxPowCurlChannel, то это теперь будет max значение
                    //
                    mMaxEnergy[i]=*std::max_element(amp_trimmed.begin(),amp_trimmed.end());
                    controls.graph->setData( time_trimmed, amp_trimmed);
                }
            }
            // Galim:
            // здесь проверяем
            /*
             *
             * Никита: менять значения только при нажатой кнопки "Регистрация"
            if(mMaxEnergy[0]>maxPowExtChannel)
            {
            //ui->lineEdit_ext->setText(QString::number(mMaxEnergy[0]));
            // выводим теперь баллы вместо значений:
            double me0 = getPowerPoints(mMaxEnergy[0], fullPowExt);
            ui->lineEdit_ext->setText(QString::number(me0,'f',1));
            maxPowExtChannel = mMaxEnergy[0];
            }
            */
            if(mMaxEnergy[1]>maxPowCurlChannel)
            {
                //ui->lineEdit_curl->setText(QString::number(mMaxEnergy[1]));
                // выводим теперь баллы вместо значений:
                double me1 = getPowerPoints(mMaxEnergy[1], fullPowCurl);
                ui->lineEdit_ext->setText(QString::number(me1,'f',1));
                maxPowCurlChannel = mMaxEnergy[1];
            }

            return;
        }
        //----------------------------------

    }


    else{
        //Кнопка отжата

    }
}

/*
void DiagnosisMaxStrengthPage::on_pushButton_registr_ext_clicked()
{
    if( !mIsSpecterChecked )
    {
        if(mMaxEnergy[0]>maxPowExtChannel)
        {

            //ui->lineEdit_ext->setText(QString::number(mMaxEnergy[0]));
            // выводим теперь баллы вместо значений:
            double me0 = getPowerPoints(mMaxEnergy[0], fullPowExt);
            ui->lineEdit_ext->setText(QString::number(me0,'f',1));
            maxPowExtChannel = mMaxEnergy[0];
            QSettings settings("MaxPow.ini", QSettings::IniFormat);
            settings.setValue("MaxPow/ExtChannel", qreal(maxPowExtChannel));
            settings.sync();
        }

    }
}


void DiagnosisMaxStrengthPage::on_pushButton_registr_curl_clicked()
{
    if( !mIsSpecterChecked )
    {

        if(mMaxEnergy[1]>maxPowCurlChannel)
        {
            //ui->lineEdit_curl->setText(QString::number(mMaxEnergy[1]));
            // выводим теперь баллы вместо значений:
            double me1 = getPowerPoints(mMaxEnergy[1], fullPowCurl);
            ui->lineEdit_ext->setText(QString::number(me1,'f',1));
            maxPowCurlChannel = mMaxEnergy[1];
            QSettings settings("MaxPow.ini", QSettings::IniFormat);
            settings.setValue("MaxPow/CurlChannel", qreal( maxPowCurlChannel ));
            settings.sync();
        }


    }
}
*/

