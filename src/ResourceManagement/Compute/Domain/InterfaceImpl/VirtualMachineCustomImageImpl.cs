// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.

namespace Microsoft.Azure.Management.Compute.Fluent
{
    using Microsoft.Azure.Management.Compute.Fluent.Models;
    using Microsoft.Azure.Management.Compute.Fluent.VirtualMachineCustomImage.CustomImageDataDisk.Definition;
    using Microsoft.Azure.Management.Compute.Fluent.VirtualMachineCustomImage.Definition;
    using Microsoft.Azure.Management.ResourceManager.Fluent;
    using System.Collections.Generic;
    using System.Threading;
    using System.Threading.Tasks;

    internal partial class VirtualMachineCustomImageImpl
    {
        /// <summary>
        /// Gets data disk images in this image, indexed by the disk LUN.
        /// </summary>
        System.Collections.Generic.IReadOnlyDictionary<int, Models.ImageDataDisk> Microsoft.Azure.Management.Compute.Fluent.IVirtualMachineCustomImage.DataDiskImages
        {
            get
            {
                return this.DataDiskImages();
            }
        }

        /// <summary>
        /// Gets true if this image was created by capturing a virtual machine.
        /// </summary>
        bool Microsoft.Azure.Management.Compute.Fluent.IVirtualMachineCustomImage.IsCreatedFromVirtualMachine
        {
            get
            {
                return this.IsCreatedFromVirtualMachine();
            }
        }

        /// <summary>
        /// Get Hyper-V image generation.
        /// </summary>
        HyperVGenerationTypes Microsoft.Azure.Management.Compute.Fluent.IVirtualMachineCustomImage.HyperVGeneration {
            get
            {
                return this.Inner.HyperVGeneration;
            }
        }

        /// <summary>
        /// Gets operating system disk image in this image.
        /// </summary>
        Models.ImageOSDisk Microsoft.Azure.Management.Compute.Fluent.IVirtualMachineCustomImage.OSDiskImage
        {
            get
            {
                return this.OSDiskImage();
            }
        }

        /// <summary>
        /// Gets ID of the virtual machine if this image was created by capturing that virtual machine.
        /// </summary>
        string Microsoft.Azure.Management.Compute.Fluent.IVirtualMachineCustomImage.SourceVirtualMachineId
        {
            get
            {
                return this.SourceVirtualMachineId();
            }
        }

        /// <summary>
        /// Begins the definition of a new data disk image to add to the image.
        /// </summary>
        /// <return>The first stage of the new data disk image definition.</return>
        VirtualMachineCustomImage.CustomImageDataDisk.Definition.IBlank<VirtualMachineCustomImage.Definition.IWithCreateAndDataDiskImageOSDiskSettings> VirtualMachineCustomImage.Definition.IWithDataDiskImage.DefineDataDiskImage()
        {
            return this.DefineDataDiskImage();
        }

        /// <summary>
        /// Uses the virtual machine's OS disk and data disks as the source for OS disk image and
        /// data disk images of this image.
        /// </summary>
        /// <param name="virtualMachineId">Source virtual machine resource ID.</param>
        /// <return>The next stage of the definition.</return>
        VirtualMachineCustomImage.Definition.IWithCreate VirtualMachineCustomImage.Definition.IWithSourceVirtualMachine.FromVirtualMachine(string virtualMachineId)
        {
            return this.FromVirtualMachine(virtualMachineId);
        }

        /// <summary>
        /// Uses the virtual machine's OS and data disks as the sources for OS disk image and data
        /// disk images of this image.
        /// </summary>
        /// <param name="virtualMachine">Source virtual machine.</param>
        /// <return>The next stage of the definition.</return>
        VirtualMachineCustomImage.Definition.IWithCreate VirtualMachineCustomImage.Definition.IWithSourceVirtualMachine.FromVirtualMachine(IVirtualMachine virtualMachine)
        {
            return this.FromVirtualMachine(virtualMachine);
        }


        /// <summary>
        /// Specifies the Hyper-V image generation.
        /// </summary>
        /// <param name="hyperVGeneration">Hyper-V image generation</param>
        /// <returns>The next stage of the definition.</returns>
        IWithOSDiskImageSourceAltVirtualMachineSource IWithHyperVGeneration.WithHyperVGeneration(HyperVGenerationTypes hyperVGeneration)
        {
            return this.WithHyperVGeneration(hyperVGeneration);
        }

        /// <summary>
        /// Adds a data disk image with an existing managed disk as the source.
        /// </summary>
        /// <param name="sourceManagedDiskId">Source managed disk resource ID.</param>
        /// <return>The next stage of the definition.</return>
        VirtualMachineCustomImage.Definition.IWithCreateAndDataDiskImageOSDiskSettings VirtualMachineCustomImage.Definition.IWithDataDiskImage.WithDataDiskImageFromManagedDisk(string sourceManagedDiskId)
        {
            return this.WithDataDiskImageFromManagedDisk(sourceManagedDiskId);
        }

        /// <summary>
        /// Adds a data disk image with an existing snapshot as the source.
        /// </summary>
        /// <param name="sourceSnapshotId">Source snapshot resource ID.</param>
        /// <return>The next stage of the definition.</return>
        VirtualMachineCustomImage.Definition.IWithCreateAndDataDiskImageOSDiskSettings VirtualMachineCustomImage.Definition.IWithDataDiskImage.WithDataDiskImageFromSnapshot(string sourceSnapshotId)
        {
            return this.WithDataDiskImageFromSnapshot(sourceSnapshotId);
        }

        /// <summary>
        /// Adds a data disk image with a virtual hard disk as the source.
        /// </summary>
        /// <param name="sourceVhdUrl">Source virtual hard disk URL.</param>
        /// <return>The next stage of the definition.</return>
        VirtualMachineCustomImage.Definition.IWithCreateAndDataDiskImageOSDiskSettings VirtualMachineCustomImage.Definition.IWithDataDiskImage.WithDataDiskImageFromVhd(string sourceVhdUrl)
        {
            return this.WithDataDiskImageFromVhd(sourceVhdUrl);
        }

        /// <summary>
        /// Specifies the Linux source managed disk for the OS disk image.
        /// </summary>
        /// <param name="sourceManagedDiskId">Source managed disk resource ID.</param>
        /// <param name="osState">Operating system state.</param>
        /// <return>The next stage of the definition.</return>
        VirtualMachineCustomImage.Definition.IWithCreateAndDataDiskImageOSDiskSettings VirtualMachineCustomImage.Definition.IWithOSDiskImageSource.WithLinuxFromDisk(string sourceManagedDiskId, OperatingSystemStateTypes osState)
        {
            return this.WithLinuxFromDisk(sourceManagedDiskId, osState);
        }

        /// <summary>
        /// Specifies the Linux source managed disk for the OS disk image.
        /// </summary>
        /// <param name="sourceManagedDisk">Source managed disk.</param>
        /// <param name="osState">Operating system state.</param>
        /// <return>The next stage of the definition.</return>
        VirtualMachineCustomImage.Definition.IWithCreateAndDataDiskImageOSDiskSettings VirtualMachineCustomImage.Definition.IWithOSDiskImageSource.WithLinuxFromDisk(IDisk sourceManagedDisk, OperatingSystemStateTypes osState)
        {
            return this.WithLinuxFromDisk(sourceManagedDisk, osState);
        }

        /// <summary>
        /// Specifies the Linux source snapshot for the OS disk image.
        /// </summary>
        /// <param name="sourceSnapshotId">Source snapshot resource ID.</param>
        /// <param name="osState">Operating system state.</param>
        /// <return>The next stage of the definition.</return>
        VirtualMachineCustomImage.Definition.IWithCreateAndDataDiskImageOSDiskSettings VirtualMachineCustomImage.Definition.IWithOSDiskImageSource.WithLinuxFromSnapshot(string sourceSnapshotId, OperatingSystemStateTypes osState)
        {
            return this.WithLinuxFromSnapshot(sourceSnapshotId, osState);
        }

        /// <summary>
        /// Specifies the Linux source snapshot for the OS disk image.
        /// </summary>
        /// <param name="sourceSnapshot">Source snapshot resource.</param>
        /// <param name="osState">Operating system state.</param>
        /// <return>The next stage of the definition.</return>
        VirtualMachineCustomImage.Definition.IWithCreateAndDataDiskImageOSDiskSettings VirtualMachineCustomImage.Definition.IWithOSDiskImageSource.WithLinuxFromSnapshot(ISnapshot sourceSnapshot, OperatingSystemStateTypes osState)
        {
            return this.WithLinuxFromSnapshot(sourceSnapshot, osState);
        }

        /// <summary>
        /// Specifies the Linux source native VHD for the OS disk image.
        /// </summary>
        /// <param name="sourceVhdUrl">Source Linux virtual hard disk URL.</param>
        /// <param name="osState">Operating system state.</param>
        /// <return>The next stage of the definition.</return>
        VirtualMachineCustomImage.Definition.IWithCreateAndDataDiskImageOSDiskSettings VirtualMachineCustomImage.Definition.IWithOSDiskImageSource.WithLinuxFromVhd(string sourceVhdUrl, OperatingSystemStateTypes osState)
        {
            return this.WithLinuxFromVhd(sourceVhdUrl, osState);
        }

        /// <summary>
        /// Specifies the caching type for OS disk.
        /// </summary>
        /// <param name="cachingType">The disk caching type.</param>
        /// <return>The next stage of the definition.</return>
        VirtualMachineCustomImage.Definition.IWithCreateAndDataDiskImageOSDiskSettings VirtualMachineCustomImage.Definition.IWithOSDiskSettings.WithOSDiskCaching(CachingTypes cachingType)
        {
            return this.WithOSDiskCaching(cachingType);
        }

        /// <summary>
        /// Specifies the size in GB for OS disk.
        /// </summary>
        /// <param name="diskSizeGB">The disk size in GB.</param>
        /// <return>The next stage of the definition.</return>
        VirtualMachineCustomImage.Definition.IWithCreateAndDataDiskImageOSDiskSettings VirtualMachineCustomImage.Definition.IWithOSDiskSettings.WithOSDiskSizeInGB(int diskSizeGB)
        {
            return this.WithOSDiskSizeInGB(diskSizeGB);
        }

        /// <summary>
        /// Specifies the Windows source managed disk for the OS disk image.
        /// </summary>
        /// <param name="sourceManagedDiskId">Source managed disk resource ID.</param>
        /// <param name="osState">Operating system state.</param>
        /// <return>The next stage of the definition.</return>
        VirtualMachineCustomImage.Definition.IWithCreateAndDataDiskImageOSDiskSettings VirtualMachineCustomImage.Definition.IWithOSDiskImageSource.WithWindowsFromDisk(string sourceManagedDiskId, OperatingSystemStateTypes osState)
        {
            return this.WithWindowsFromDisk(sourceManagedDiskId, osState);
        }

        /// <summary>
        /// Specifies the Windows source managed disk for the OS disk image.
        /// </summary>
        /// <param name="sourceManagedDisk">Source managed disk.</param>
        /// <param name="osState">Operating system state.</param>
        /// <return>The next stage of the definition.</return>
        VirtualMachineCustomImage.Definition.IWithCreateAndDataDiskImageOSDiskSettings VirtualMachineCustomImage.Definition.IWithOSDiskImageSource.WithWindowsFromDisk(IDisk sourceManagedDisk, OperatingSystemStateTypes osState)
        {
            return this.WithWindowsFromDisk(sourceManagedDisk, osState);
        }

        /// <summary>
        /// Specifies the Windows source snapshot for the OS disk image.
        /// </summary>
        /// <param name="sourceSnapshotId">Source snapshot resource ID.</param>
        /// <param name="osState">Operating system state.</param>
        /// <return>The next stage of the definition.</return>
        VirtualMachineCustomImage.Definition.IWithCreateAndDataDiskImageOSDiskSettings VirtualMachineCustomImage.Definition.IWithOSDiskImageSource.WithWindowsFromSnapshot(string sourceSnapshotId, OperatingSystemStateTypes osState)
        {
            return this.WithWindowsFromSnapshot(sourceSnapshotId, osState);
        }

        /// <summary>
        /// Specifies the Windows source snapshot for the OS disk image.
        /// </summary>
        /// <param name="sourceSnapshot">Source snapshot resource.</param>
        /// <param name="osState">Operating system state.</param>
        /// <return>The next stage of the definition.</return>
        VirtualMachineCustomImage.Definition.IWithCreateAndDataDiskImageOSDiskSettings VirtualMachineCustomImage.Definition.IWithOSDiskImageSource.WithWindowsFromSnapshot(ISnapshot sourceSnapshot, OperatingSystemStateTypes osState)
        {
            return this.WithWindowsFromSnapshot(sourceSnapshot, osState);
        }

        /// <summary>
        /// Specifies the Windows source native VHD for the OS disk image.
        /// </summary>
        /// <param name="sourceVhdUrl">Source Windows virtual hard disk URL.</param>
        /// <param name="osState">Operating system state.</param>
        /// <return>The next stage of the definition.</return>
        VirtualMachineCustomImage.Definition.IWithCreateAndDataDiskImageOSDiskSettings VirtualMachineCustomImage.Definition.IWithOSDiskImageSource.WithWindowsFromVhd(string sourceVhdUrl, OperatingSystemStateTypes osState)
        {
            return this.WithWindowsFromVhd(sourceVhdUrl, osState);
        }

        /// <summary>
        /// Specifies that zone resiliency should be enabled for the image.
        /// </summary>
        /// <return>The next stage of the definition.</return>
        VirtualMachineCustomImage.Definition.IWithCreate VirtualMachineCustomImage.Definition.IWithZoneResilient.WithZoneResilient()
        {
            return this.WithZoneResilient();
        }
    }
}