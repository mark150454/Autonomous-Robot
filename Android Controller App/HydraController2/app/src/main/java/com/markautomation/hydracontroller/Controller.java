package com.markautomation.hydracontroller;

import android.app.ProgressDialog;
import android.bluetooth.BluetoothAdapter;
import android.bluetooth.BluetoothDevice;
import android.bluetooth.BluetoothSocket;
import android.content.Intent;
import android.os.AsyncTask;
import android.support.v7.app.AppCompatActivity;
import android.os.Bundle;
import android.view.Menu;
import android.view.MenuItem;
import android.view.MotionEvent;
import android.view.View;
import android.widget.Button;
import android.widget.ImageButton;
import android.widget.Switch;
import android.widget.TextView;
import android.widget.Toast;

import java.io.IOException;
import java.util.UUID;


public class Controller extends AppCompatActivity {

    ImageButton btnUp, btnLeft, btnDown, btnRight;
    Button btnSettings;
    Switch manualSwitch;
    TextView manualModeText;
    String address = null;
    private ProgressDialog progress;
    BluetoothAdapter myBluetooth = null;
    BluetoothSocket btSocket = null;
    private boolean isBtConnected = false;
    //SPP UUID. Look for it
    static final UUID myUUID = UUID.fromString("00001101-0000-1000-8000-00805F9B34FB");


    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_controller);

        btnUp = (ImageButton) findViewById(R.id.Up);
        btnLeft = (ImageButton) findViewById(R.id.Left);
        btnDown = (ImageButton) findViewById(R.id.Down);
        btnRight = (ImageButton) findViewById(R.id.Right);
        btnSettings = (Button) findViewById(R.id.settings);
        manualSwitch = (Switch) findViewById(R.id.switch1);
        manualModeText = (TextView) findViewById(R.id.txtManualMode);

        btnRight.setEnabled(false);
        btnUp.setEnabled(false);
        btnLeft.setEnabled(false);
        btnDown.setEnabled(false);

        Intent newint = getIntent();
        address = newint.getStringExtra(MainActivity.EXTRA_ADDRESS); //receive the address of the bluetooth device

        new ConnectBT().execute(); //Call the class to connect

        btnUp.setOnTouchListener(new View.OnTouchListener() {
            @Override
            public boolean onTouch(View v, MotionEvent event) {
                if (event.getAction() == MotionEvent.ACTION_DOWN) {
                    btnUpClick();
                } else if (event.getAction() == MotionEvent.ACTION_UP) {
                    brake();
                }
                return false;
            }
        });

        btnDown.setOnTouchListener(new View.OnTouchListener() {
            @Override
            public boolean onTouch(View v, MotionEvent event) {
                if(event.getAction() == MotionEvent.ACTION_DOWN) {
                    btnDownClick();
                }
                else if(event.getAction() == MotionEvent.ACTION_UP)
                {
                    brake();
                }
                return false;
            }
        });

        btnLeft.setOnTouchListener(new View.OnTouchListener() {
            @Override
            public boolean onTouch(View v, MotionEvent event) {
                if(event.getAction() == MotionEvent.ACTION_DOWN)
                {
                    btnLeftClick();
                }
                else if(event.getAction() == MotionEvent.ACTION_UP)
                {
                    brake();
                }
                return false;
            }
        });

        btnRight.setOnTouchListener(new View.OnTouchListener() {
            @Override
            public boolean onTouch(View v, MotionEvent event) {
                if(event.getAction() == MotionEvent.ACTION_DOWN)
                {
                    btnRightClick();
                }
                else if(event.getAction() == MotionEvent.ACTION_UP)
                {
                    brake();
                }
                return false;
            }
        });

        btnSettings.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View v) {
                settings();
            }
        });

        manualSwitch.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View v) {
                setMode();
            }
        });
    }

    @Override
    public boolean onCreateOptionsMenu(Menu menu) {
        // Inflate the menu; this adds items to the action bar if it is present.
        getMenuInflater().inflate(R.menu.menu_controller, menu);
        return true;
    }

    @Override
    public boolean onOptionsItemSelected(MenuItem item) {
        // Handle action bar item clicks here. The action bar will
        // automatically handle clicks on the Home/Up button, so long
        // as you specify a parent activity in AndroidManifest.xml.
        int id = item.getItemId();

        //noinspection SimplifiableIfStatement
        if (id == R.id.action_settings) {
            return true;
        }

        return super.onOptionsItemSelected(item);
    }

    //////////////////////////////////////

    private class ConnectBT extends AsyncTask<Void, Void, Void>  // UI thread
    {
        private boolean ConnectSuccess = true; //if it's here, it's almost connected

        @Override
        protected void onPreExecute()
        {
            progress = ProgressDialog.show(Controller.this, "Connecting...", "Please wait!!!");  //show a progress dialog
        }

        @Override
        protected Void doInBackground(Void... devices) //while the progress dialog is shown, the connection is done in background
        {
            try
            {
                if (btSocket == null || !isBtConnected)
                {
                    myBluetooth = BluetoothAdapter.getDefaultAdapter();//get the mobile bluetooth device
                    BluetoothDevice bt = myBluetooth.getRemoteDevice(address);//connects to the device's address and checks if it's available
                    btSocket = bt.createInsecureRfcommSocketToServiceRecord(myUUID);//create a RFCOMM (SPP) connection
                    BluetoothAdapter.getDefaultAdapter().cancelDiscovery();
                    btSocket.connect();//start connection
                }
            }
            catch (IOException e)
            {
                ConnectSuccess = false;//if the try failed, you can check the exception here
            }
            return null;
        }
        @Override
        protected void onPostExecute(Void result) //after the doInBackground, it checks if everything went fine
        {
            super.onPostExecute(result);

            if (!ConnectSuccess)
            {
                msg("Connection Failed. Is the paired device's bluetooth on? Try again.");
                finish();
            }
            else
            {
                msg("Connected.");
                isBtConnected = true;
            }
            progress.dismiss();
        }
    }

    private void msg(String s)
    {
        Toast.makeText(getApplicationContext(), s, Toast.LENGTH_LONG).show();
    }

    private void btnUpClick()
    {
        if (btSocket!=null)
        {
            try
            {
                btSocket.getOutputStream().write("8".toString().getBytes());
            }
            catch (IOException e)
            {
                msg("Error");
            }
        }
    }

    private void btnLeftClick()
    {
        if (btSocket!=null)
        {
            try
            {
                btSocket.getOutputStream().write("4".toString().getBytes());
            }
            catch (IOException e)
            {
                msg("Error");
            }
        }
    }

    private void btnDownClick()
    {
        if (btSocket!=null)
        {
            try
            {
                btSocket.getOutputStream().write("2".toString().getBytes());
            }
            catch (IOException e)
            {
                msg("Error");
            }
        }
    }

    private void btnRightClick()
    {
        if (btSocket!=null)
        {
            try
            {
                btSocket.getOutputStream().write("6".toString().getBytes());
            }
            catch (IOException e)
            {
                msg("Error");
            }
        }
    }

    private void setMode()
    {
        if(manualSwitch.isChecked() && isBtConnected)
        {
            if (btSocket!=null)
            {
                try
                {
                    btSocket.getOutputStream().write("manual".toString().getBytes());
                    manualModeText.setText("Manual Mode (ON)");
                }
                catch (IOException e)
                {
                    msg("Error");
                }
            }
            btnRight.setEnabled(true);
            btnUp.setEnabled(true);
            btnLeft.setEnabled(true);
            btnDown.setEnabled(true);
        }
        else if(!manualSwitch.isChecked())
        {
            if (btSocket!=null)
            {
                try
                {
                    btSocket.getOutputStream().write("auto".toString().getBytes());
                    manualModeText.setText("Manual Mode(OFF)");
                }
                catch (IOException e)
                {
                    msg("Error");
                }
            }
            btnRight.setEnabled(false);
            btnUp.setEnabled(false);
            btnLeft.setEnabled(false);
            btnDown.setEnabled(false);
        }
        else
        {
            msg("Could not perform action.");
        }
    }

    private void brake()
    {
        if (btSocket!=null)
        {
            try
            {
                btSocket.getOutputStream().write("5".toString().getBytes());
            }
            catch (IOException e)
            {
                msg("Error");
            }
        }
    }

    private void settings()
    {
        startActivity(new Intent(getApplicationContext(), Settings.class));
    }
}
