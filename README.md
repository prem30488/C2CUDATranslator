C2CUDATranslator
================

C2CUDATranslator

As today in so many fields, computation is the main part of the algorithm and takes too much time in execution of the algorithm, it is necessary to parallelize the computation or reduce execution time. GPUs are widely used in (HPC) High Performance Computing. To achieve speedup, either we can increase clock frequency or multiple computation cores on the same chip. The clock speeds have reached the physical limit, so the use of many cores is the only way left to achieve speedup. As the GPU is growing demand of the Game Industry and large scientific computations, efforts have been made to take advantages to gain maximum utilization of the GPUs in computation. Though GPUs are widely used in Supercomputers today, they are not code transparent because one has to sit and code the algorithms in CUDA C to run them on GPU. So if we can have some middleware that converts the C programs to CUDA, the end user gets transparency. I tried to develop a prototype compiler using ANTLR in visual studio that converts the C programs in CUDA C language. The thesis describes the literature survey in CUDA, different performance optimization strategies to reduce execution time, the Pattern approach to develop a translator for source code to source code translation on the basis of selection of codes using patterns, platforms to code such translator and platform comparison and choice and algorithm of translation. The Compiler Architecture and its implementation details are widely described in thesis. The thesis describes implementation of the complete C2CUDATranslator, testing and analysis of the developed compiler. The compiler takes input of C program and generates CUDA program. The thesis demonstrates the pattern approach for language to language translation and the compiler flow architecture. C2CUDAranslator covers a new way or a framework to implement new analysis algorithms to detect dependencies in the code. The thesis also covers neural network design for compiler learning and optimization of the translated code. The Neural Network helps compiler to take decision for selection of transformation and translation. Finally, the thesis covers outcome of the compiler, converted programs list, evaluation using parboil benchmark suite, performance graph of converted programs. It is concluded that the C2CUDATranslator saves 95% of the development time in selected cases. C2CUDA Translator converts C code to CUDA. It is also a framework to develop analysis and dependency checking algorithms for other developers. 

Developer's Guide
=================

Developer's Guide C2CUDATranslator is very easy to work with. Developers are required to know C, CUDA C in detail in advance before using C2CUDATranslator. Additionally they are required to know ANTLR compulsory.

C.1 Getting Started

C2CUDATranslaor is like a framework to develop and test various code analysis algorithms in the field of source code to source code translation.

C.1.1 C2CUDATranslator Project Structure 

The design of the project is shown below. Developers can see the Visual 2008 Solution project as given design on project website.

http://sites.google.com/a/nirmauni.ac.in/a/nirmauni.ac.in/cudacodes

C.2 C2CUDATranslator development Details 

C.2.1 Analysis Framework 

In C2CUDATranslator there is a file "Analysis.cs" which contains analysis algorithms. One can write his/her own algorithm in this file as a class or new function and can call in the parser. But the namespace must be C2CUDAranslator.Analysis. 

C.2.2 Translation Framework 

Similarly, C2CUDATranslator.Translation is the framework that contains classes and codes for translation. Developers will find FOR, BLOCK etc. classes. They may contain properties like LOOP.index, LOOP.IsNestLoop etc. 

C.2.3 Use framework 

Developers can use collections those contains readonly, write-only variables and can use them in conditions in making analysis algorithms.


User's Guide
============

C2CUDATranslator is very easy to use. Users are required to know C in advance before using C2CUDATranslator.

B.1 Getting Started 

B.1.1 Input and Output of C2CUDATranslator

Input.file - input to translator (C File) 
Output.file - output of the translator (CUDA File)

First, copy C program to input.file and run the translator. After running the translator copy CUDA code that has been converted or copy content of output.file. Put them in CUDA project. Run the project. 

B.2 C2CUDATranslator input Details 

B.2.1 Kernel Outlining

The kernel is the code to be ported on the GPU. So, First identify the code you want to run on GPU. It may be some computation code such as loops. Now, write "#pragma kernel start" before that code and at the end of the code write "#pragma kernel end".

Example

pragma kernel start 
for (i = 1; i <= 100; ++i) 
{ 
  for (j = 0; j < 100; ++j) 
  { 
    a [i ] [j ] = b[i ] [j ] + c[i ] [j ]; 
  } 
} 
pragma kernel end

B.2.2 Kernel Variables Kernel variables are the variables which are copied to/from host/devices. User can specify them in their code by writing "kernel" in the declaration of that variable.

Example

int a [100 ] [100 ]; int b [100 ] [100 ]; int c [100 ] [100 ];

a,b & c arrays are used in kernel. So, we will write them as

kernel int a[100 ] [100 ]; kernel int b[100 ] [100 ]; kernel int c[100 ] [100 ];

B.2.3 Kernel local Variables

If there are some local variables in the kernel code, they does not need to be copied to/from host/device. They can be initialized in GPU. We can write "local kernel" before the declaration statements of them.

Example

int n=3; int P=100;

n & P are local variables used in kernel region. So, we will write them as local kernel int n=3; local kernel int P=100;
