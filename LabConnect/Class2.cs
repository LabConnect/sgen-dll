using Microsoft.Win32.SafeHandles;
using System;
using System.Diagnostics;
using System.Globalization;
using System.IO;
using System.Management;
using System.Runtime.InteropServices;
using System.Threading;
using System.Timers;

namespace GenericHid
{
    class FindHid
    {
        public GenericHid.Hid _myHid = new GenericHid.Hid();
        private readonly GenericHid.DeviceManagement _myDeviceManagement = new GenericHid.DeviceManagement();

        private Boolean _deviceHandleObtained;
        public SafeFileHandle _hidHandle;
        private String _hidUsage;
        private FileStream _deviceData;

        public Boolean enumerate(int vid, int pid)
        {
            var devicePathName = new String[128];
            String myDevicePathName = "";

            try
            {
                _deviceHandleObtained = false;
                //CloseCommunications();

                // Get the HID-class GUID.
                Guid hidGuid = _myHid.GetHidGuid();

                //  Fill an array with the device path names of all attached HIDs.
                Boolean availableHids = _myDeviceManagement.FindDeviceFromGuid(hidGuid, ref devicePathName);

                //  If there is at least one HID, attempt to read the Vendor ID and Product ID
                //  of each device until there is a match or all devices have been examined.
                if (availableHids)
                {
                    Int32 memberIndex = 0;

                    do
                    {
                        // Open the handle without read/write access to enable getting information about any HID, even system keyboards and mice.
                        _hidHandle = _myHid.OpenHandle(devicePathName[memberIndex], false);

                        if (!_hidHandle.IsInvalid)
                        {
                            // The returned handle is valid, 
                            // so find out if this is the device we're looking for.
                            _myHid.DeviceAttributes.Size = Marshal.SizeOf(_myHid.DeviceAttributes);

                            Boolean success = _myHid.GetAttributes(_hidHandle, ref _myHid.DeviceAttributes);
                            if (success)
                            {
                                if ((_myHid.DeviceAttributes.VendorID == vid) && (_myHid.DeviceAttributes.ProductID == pid))
                                {

                                    _deviceHandleObtained = true;
                                    myDevicePathName = devicePathName[memberIndex];
                                }
                                else
                                {
                                    _deviceHandleObtained = false;
                                    _hidHandle.Close();
                                }
                            }
                            else
                            {

                                _deviceHandleObtained = false;
                                _hidHandle.Close();
                            }
                        }

                        //  Keep looking until we find the device or there are no devices left to examine.
                        memberIndex = memberIndex + 1;
                    }
                    while (!((_deviceHandleObtained || (memberIndex == devicePathName.Length))));
                }

                //  The device was detected.
                if (_deviceHandleObtained)
                {
                    //  Learn the capabilities of the device.
                    _myHid.Capabilities = _myHid.GetDeviceCapabilities(_hidHandle);

                    //  Find out if the device is a system mouse or keyboard.
                    _hidUsage = _myHid.GetHidUsage(_myHid.Capabilities);

                    //  Get the Input report buffer size.
                    GetInputReportBufferSize();


                    //Close the handle and reopen it with read/write access.
                    _hidHandle.Close();
                    _hidHandle = _myHid.OpenHandle(myDevicePathName, true);

                    if (_hidHandle.IsInvalid)
                    {

                    }
                    else
                    {
                        if (_myHid.Capabilities.InputReportByteLength > 0)
                        {
                            //  Set the size of the Input report buffer. 
                            var inputReportBuffer = new Byte[_myHid.Capabilities.InputReportByteLength];
                            _deviceData = new FileStream(_hidHandle, FileAccess.Read | FileAccess.Write, inputReportBuffer.Length, false);
                        }

                        if (_myHid.Capabilities.OutputReportByteLength > 0)
                        {
                            Byte[] outputReportBuffer = null;
                        }
                        //  Flush any waiting reports in the input buffer. (optional)

                        _myHid.FlushQueue(_hidHandle);
                    }
                }
                else
                {

                }
                return _deviceHandleObtained;
            }
            catch (Exception ex)
            {

                throw;
            }
        }

        private void GetInputReportBufferSize()
        {
            Int32 numberOfInputBuffers = 0;


            try
            {
                //  Get the number of input buffers.

                _myHid.GetNumberOfInputBuffers(_hidHandle, ref numberOfInputBuffers);


            }
            catch (Exception ex)
            {

                throw;
            }
        }
    }
}
