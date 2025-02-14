// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.ResourceManager.Compute;

namespace Azure.ResourceManager.Compute.Models
{
    /// <summary> Describes virtual machine scale set operating system disk Update Object. This should be used for Updating VMSS OS Disk. </summary>
    public partial class VirtualMachineScaleSetUpdateOSDisk
    {
        /// <summary>
        /// Keeps track of any properties unknown to the library.
        /// <para>
        /// To assign an object to the value of this property use <see cref="BinaryData.FromObjectAsJson{T}(T, System.Text.Json.JsonSerializerOptions?)"/>.
        /// </para>
        /// <para>
        /// To assign an already formatted json string to this property use <see cref="BinaryData.FromString(string)"/>.
        /// </para>
        /// <para>
        /// Examples:
        /// <list type="bullet">
        /// <item>
        /// <term>BinaryData.FromObjectAsJson("foo")</term>
        /// <description>Creates a payload of "foo".</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromString("\"foo\"")</term>
        /// <description>Creates a payload of "foo".</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromObjectAsJson(new { key = "value" })</term>
        /// <description>Creates a payload of { "key": "value" }.</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromString("{\"key\": \"value\"}")</term>
        /// <description>Creates a payload of { "key": "value" }.</description>
        /// </item>
        /// </list>
        /// </para>
        /// </summary>
        private IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="VirtualMachineScaleSetUpdateOSDisk"/>. </summary>
        public VirtualMachineScaleSetUpdateOSDisk()
        {
            VhdContainers = new ChangeTrackingList<string>();
        }

        /// <summary> Initializes a new instance of <see cref="VirtualMachineScaleSetUpdateOSDisk"/>. </summary>
        /// <param name="caching"> The caching type. </param>
        /// <param name="writeAcceleratorEnabled"> Specifies whether writeAccelerator should be enabled or disabled on the disk. </param>
        /// <param name="diskSizeGB"> Specifies the size of an empty data disk in gigabytes. This element can be used to overwrite the size of the disk in a virtual machine image. &lt;br&gt;&lt;br&gt; diskSizeGB is the number of bytes x 1024^3 for the disk and the value cannot be larger than 1023. </param>
        /// <param name="image"> The Source User Image VirtualHardDisk. This VirtualHardDisk will be copied before using it to attach to the Virtual Machine. If SourceImage is provided, the destination VirtualHardDisk should not exist. </param>
        /// <param name="vhdContainers"> The list of virtual hard disk container uris. </param>
        /// <param name="managedDisk"> The managed disk parameters. </param>
        /// <param name="deleteOption"> Specifies whether OS Disk should be deleted or detached upon VMSS Flex deletion (This feature is available for VMSS with Flexible OrchestrationMode only). &lt;br&gt;&lt;br&gt; Possible values: &lt;br&gt;&lt;br&gt; **Delete** If this value is used, the OS disk is deleted when VMSS Flex VM is deleted.&lt;br&gt;&lt;br&gt; **Detach** If this value is used, the OS disk is retained after VMSS Flex VM is deleted. &lt;br&gt;&lt;br&gt; The default value is set to **Delete**. For an Ephemeral OS Disk, the default value is set to **Delete**. User cannot change the delete option for Ephemeral OS Disk. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal VirtualMachineScaleSetUpdateOSDisk(CachingType? caching, bool? writeAcceleratorEnabled, int? diskSizeGB, VirtualHardDisk image, IList<string> vhdContainers, VirtualMachineScaleSetManagedDisk managedDisk, DiskDeleteOptionType? deleteOption, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Caching = caching;
            WriteAcceleratorEnabled = writeAcceleratorEnabled;
            DiskSizeGB = diskSizeGB;
            Image = image;
            VhdContainers = vhdContainers;
            ManagedDisk = managedDisk;
            DeleteOption = deleteOption;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> The caching type. </summary>
        public CachingType? Caching { get; set; }
        /// <summary> Specifies whether writeAccelerator should be enabled or disabled on the disk. </summary>
        public bool? WriteAcceleratorEnabled { get; set; }
        /// <summary> Specifies the size of an empty data disk in gigabytes. This element can be used to overwrite the size of the disk in a virtual machine image. &lt;br&gt;&lt;br&gt; diskSizeGB is the number of bytes x 1024^3 for the disk and the value cannot be larger than 1023. </summary>
        public int? DiskSizeGB { get; set; }
        /// <summary> The Source User Image VirtualHardDisk. This VirtualHardDisk will be copied before using it to attach to the Virtual Machine. If SourceImage is provided, the destination VirtualHardDisk should not exist. </summary>
        internal VirtualHardDisk Image { get; set; }
        /// <summary> Specifies the virtual hard disk's uri. </summary>
        public Uri ImageUri
        {
            get => Image is null ? default : Image.Uri;
            set
            {
                if (Image is null)
                    Image = new VirtualHardDisk();
                Image.Uri = value;
            }
        }

        /// <summary> The list of virtual hard disk container uris. </summary>
        public IList<string> VhdContainers { get; }
        /// <summary> The managed disk parameters. </summary>
        public VirtualMachineScaleSetManagedDisk ManagedDisk { get; set; }
        /// <summary> Specifies whether OS Disk should be deleted or detached upon VMSS Flex deletion (This feature is available for VMSS with Flexible OrchestrationMode only). &lt;br&gt;&lt;br&gt; Possible values: &lt;br&gt;&lt;br&gt; **Delete** If this value is used, the OS disk is deleted when VMSS Flex VM is deleted.&lt;br&gt;&lt;br&gt; **Detach** If this value is used, the OS disk is retained after VMSS Flex VM is deleted. &lt;br&gt;&lt;br&gt; The default value is set to **Delete**. For an Ephemeral OS Disk, the default value is set to **Delete**. User cannot change the delete option for Ephemeral OS Disk. </summary>
        public DiskDeleteOptionType? DeleteOption { get; set; }
    }
}
