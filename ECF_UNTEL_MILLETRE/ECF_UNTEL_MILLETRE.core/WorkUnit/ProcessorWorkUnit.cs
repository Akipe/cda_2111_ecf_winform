﻿using ECF_UNTEL_MILLETRE.core.Model;
using ECF_UNTEL_MILLETRE.core.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace ECF_UNTEL_MILLETRE.core.WorkUnit
{
    public class ProcessorWorkUnit
    {
        public const string DATA_FILE_NAME = "cpu-untel.json";
        public readonly string AppDirPath;
        public readonly string DataFilePath;

        public ProcessorWorkUnit()
        {
            AppDirPath = Environment.GetFolderPath(
                Environment.SpecialFolder.Desktop
            );
            DataFilePath = Path.Combine(AppDirPath, DATA_FILE_NAME);
        }

        public void AddOne(AddProcessorViewModel viewModel)
        {
            ProcessorFamily family = new ProcessorFamily(viewModel._familyName, viewModel._familyArch);
            Processor proc = new Processor(
                family,
                viewModel._referenceDigit,
                viewModel._referenceLetter,
                viewModel._name,
                viewModel._releaseDate,
                viewModel._price,
                viewModel._frequency
            );


            ProcessorManager.List.Add(proc);
        }

        public ShowProcessorViewModel GetInfoFromOne(string procName)
        {
            ShowProcessorViewModel viewModel = new ShowProcessorViewModel();

            foreach (Processor proc in ProcessorManager.List)
            {
                if (procName == proc.Name)
                {
                    viewModel.FromOne(proc);
                }
            }

            return viewModel;
        }

        public List<string> GetListProcName()
        {
            List<string> listProcName = new List<string>();

            foreach (Processor proc in ProcessorManager.List)
            {
                listProcName.Add(proc.Name);
            }

            return listProcName;
        }

        public bool Save()
        {
            string json = JsonSerializer.Serialize(ProcessorManager.List);

            try
            {
                File.WriteAllText(DataFilePath, json, Encoding.UTF8);

                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public void Load()
        {
            if (File.Exists(DataFilePath))
            {
                string json = File.ReadAllText(DataFilePath, Encoding.UTF8);

                ProcessorManager.List = JsonSerializer.Deserialize<List<Processor>>(json);
            }
            else
            {
                ProcessorManager.List.Add(new Processor(
                    new ProcessorFamily("LAKE", ProcessorArch.x86),
                    1200,
                    'F',
                    "Kakao",
                    new DateTime(2018, 05, 02),
                    99,
                    2.7
                ));
                ProcessorManager.List.Add(new Processor(
                    new ProcessorFamily("LAKE", ProcessorArch.x64),
                    5600,
                    'X',
                    "ProLiner",
                    new DateTime(2019, 09, 12),
                    189,
                    3.2
                ));
                ProcessorManager.List.Add(new Processor(
                    new ProcessorFamily("SUMO", ProcessorArch.x64),
                    8000,
                    'X',
                    "SayPlusPlus",
                    new DateTime(2021, 11, 12),
                    479,
                    4.333
                ));
            }
        }
    }
}
