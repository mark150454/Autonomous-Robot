package com.markautomation.hydracontroller;

import android.support.v7.app.AppCompatActivity;
import android.os.Bundle;
import android.view.Menu;
import android.view.MenuItem;
import android.view.MotionEvent;
import android.view.View;
import android.widget.Button;
import android.widget.SeekBar;
import android.widget.TextView;

import org.w3c.dom.Text;

public class Settings extends AppCompatActivity {

    Button btnBack;
    SeekBar rightMotorSpeed, leftMotorSpeed;
    TextView rightMotorSpeedText, leftMotorSpeedText;

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_settings);

        btnBack = (Button) findViewById(R.id.btnBack);
        rightMotorSpeed = (SeekBar) findViewById(R.id.seekbarRightMotor);
        leftMotorSpeed = (SeekBar) findViewById(R.id.seekBarLeftMotor);
        rightMotorSpeedText = (TextView) findViewById(R.id.rightMotorSpeedText);
        leftMotorSpeedText = (TextView) findViewById(R.id.leftMotorSpeedText);

        btnBack.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View v) {
                goBack();
            }
        });

        rightMotorSpeed.setOnTouchListener(new View.OnTouchListener() {
            @Override
            public boolean onTouch(View v, MotionEvent event) {
                if (event.getAction() == MotionEvent.ACTION_DOWN) {
                    rightMotorSpeedText.setText("Right Motor Speed: " + rightMotorSpeed.getProgress());
                } else if (event.getAction() == MotionEvent.ACTION_UP) {

                }
                return false;
            }
        });

        leftMotorSpeed.setOnTouchListener(new View.OnTouchListener() {
            @Override
            public boolean onTouch(View v, MotionEvent event) {
                if(event.getAction() == MotionEvent.ACTION_DOWN)
                {
                    leftMotorSpeedText.setText("Left Motor Speed: " + leftMotorSpeed.getProgress());
                }
                else if(event.getAction() == MotionEvent.ACTION_UP)
                {

                }
                return false;
            }
        });
    }

    @Override
    public boolean onCreateOptionsMenu(Menu menu) {
        // Inflate the menu; this adds items to the action bar if it is present.
        getMenuInflater().inflate(R.menu.menu_settings, menu);
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

    private void goBack()
    {
        finish();
    }


}
