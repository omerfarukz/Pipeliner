﻿

using System;

namespace Pipeliner;

public static class GeneratedPipelineExtensions
{

    public static ITransformPipe<T0, T2> Combine<T0,T1,T2>(this ISourcePipe<T0> sourcePipe, Func<T0, T1> f0,Func<T1, T2> f1) => new TransformPipe<T0, T2>(f => f1(f0(f)));
    public static ITransformPipe<T0, T3> Combine<T0,T1,T2,T3>(this ISourcePipe<T0> sourcePipe, Func<T0, T1> f0,Func<T1, T2> f1,Func<T2, T3> f2) => new TransformPipe<T0, T3>(f => f2(f1(f0(f))));
    public static ITransformPipe<T0, T4> Combine<T0,T1,T2,T3,T4>(this ISourcePipe<T0> sourcePipe, Func<T0, T1> f0,Func<T1, T2> f1,Func<T2, T3> f2,Func<T3, T4> f3) => new TransformPipe<T0, T4>(f => f3(f2(f1(f0(f)))));
    public static ITransformPipe<T0, T5> Combine<T0,T1,T2,T3,T4,T5>(this ISourcePipe<T0> sourcePipe, Func<T0, T1> f0,Func<T1, T2> f1,Func<T2, T3> f2,Func<T3, T4> f3,Func<T4, T5> f4) => new TransformPipe<T0, T5>(f => f4(f3(f2(f1(f0(f))))));
    public static ITransformPipe<T0, T6> Combine<T0,T1,T2,T3,T4,T5,T6>(this ISourcePipe<T0> sourcePipe, Func<T0, T1> f0,Func<T1, T2> f1,Func<T2, T3> f2,Func<T3, T4> f3,Func<T4, T5> f4,Func<T5, T6> f5) => new TransformPipe<T0, T6>(f => f5(f4(f3(f2(f1(f0(f)))))));
    public static ITransformPipe<T0, T7> Combine<T0,T1,T2,T3,T4,T5,T6,T7>(this ISourcePipe<T0> sourcePipe, Func<T0, T1> f0,Func<T1, T2> f1,Func<T2, T3> f2,Func<T3, T4> f3,Func<T4, T5> f4,Func<T5, T6> f5,Func<T6, T7> f6) => new TransformPipe<T0, T7>(f => f6(f5(f4(f3(f2(f1(f0(f))))))));
    public static ITransformPipe<T0, T8> Combine<T0,T1,T2,T3,T4,T5,T6,T7,T8>(this ISourcePipe<T0> sourcePipe, Func<T0, T1> f0,Func<T1, T2> f1,Func<T2, T3> f2,Func<T3, T4> f3,Func<T4, T5> f4,Func<T5, T6> f5,Func<T6, T7> f6,Func<T7, T8> f7) => new TransformPipe<T0, T8>(f => f7(f6(f5(f4(f3(f2(f1(f0(f)))))))));
    public static ITransformPipe<T0, T9> Combine<T0,T1,T2,T3,T4,T5,T6,T7,T8,T9>(this ISourcePipe<T0> sourcePipe, Func<T0, T1> f0,Func<T1, T2> f1,Func<T2, T3> f2,Func<T3, T4> f3,Func<T4, T5> f4,Func<T5, T6> f5,Func<T6, T7> f6,Func<T7, T8> f7,Func<T8, T9> f8) => new TransformPipe<T0, T9>(f => f8(f7(f6(f5(f4(f3(f2(f1(f0(f))))))))));
    public static ITransformPipe<T0, T10> Combine<T0,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10>(this ISourcePipe<T0> sourcePipe, Func<T0, T1> f0,Func<T1, T2> f1,Func<T2, T3> f2,Func<T3, T4> f3,Func<T4, T5> f4,Func<T5, T6> f5,Func<T6, T7> f6,Func<T7, T8> f7,Func<T8, T9> f8,Func<T9, T10> f9) => new TransformPipe<T0, T10>(f => f9(f8(f7(f6(f5(f4(f3(f2(f1(f0(f)))))))))));
    public static ITransformPipe<T0, T11> Combine<T0,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11>(this ISourcePipe<T0> sourcePipe, Func<T0, T1> f0,Func<T1, T2> f1,Func<T2, T3> f2,Func<T3, T4> f3,Func<T4, T5> f4,Func<T5, T6> f5,Func<T6, T7> f6,Func<T7, T8> f7,Func<T8, T9> f8,Func<T9, T10> f9,Func<T10, T11> f10) => new TransformPipe<T0, T11>(f => f10(f9(f8(f7(f6(f5(f4(f3(f2(f1(f0(f))))))))))));
    public static ITransformPipe<T0, T12> Combine<T0,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12>(this ISourcePipe<T0> sourcePipe, Func<T0, T1> f0,Func<T1, T2> f1,Func<T2, T3> f2,Func<T3, T4> f3,Func<T4, T5> f4,Func<T5, T6> f5,Func<T6, T7> f6,Func<T7, T8> f7,Func<T8, T9> f8,Func<T9, T10> f9,Func<T10, T11> f10,Func<T11, T12> f11) => new TransformPipe<T0, T12>(f => f11(f10(f9(f8(f7(f6(f5(f4(f3(f2(f1(f0(f)))))))))))));
    public static ITransformPipe<T0, T13> Combine<T0,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13>(this ISourcePipe<T0> sourcePipe, Func<T0, T1> f0,Func<T1, T2> f1,Func<T2, T3> f2,Func<T3, T4> f3,Func<T4, T5> f4,Func<T5, T6> f5,Func<T6, T7> f6,Func<T7, T8> f7,Func<T8, T9> f8,Func<T9, T10> f9,Func<T10, T11> f10,Func<T11, T12> f11,Func<T12, T13> f12) => new TransformPipe<T0, T13>(f => f12(f11(f10(f9(f8(f7(f6(f5(f4(f3(f2(f1(f0(f))))))))))))));
    public static ITransformPipe<T0, T14> Combine<T0,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14>(this ISourcePipe<T0> sourcePipe, Func<T0, T1> f0,Func<T1, T2> f1,Func<T2, T3> f2,Func<T3, T4> f3,Func<T4, T5> f4,Func<T5, T6> f5,Func<T6, T7> f6,Func<T7, T8> f7,Func<T8, T9> f8,Func<T9, T10> f9,Func<T10, T11> f10,Func<T11, T12> f11,Func<T12, T13> f12,Func<T13, T14> f13) => new TransformPipe<T0, T14>(f => f13(f12(f11(f10(f9(f8(f7(f6(f5(f4(f3(f2(f1(f0(f)))))))))))))));
    public static ITransformPipe<T0, T15> Combine<T0,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14,T15>(this ISourcePipe<T0> sourcePipe, Func<T0, T1> f0,Func<T1, T2> f1,Func<T2, T3> f2,Func<T3, T4> f3,Func<T4, T5> f4,Func<T5, T6> f5,Func<T6, T7> f6,Func<T7, T8> f7,Func<T8, T9> f8,Func<T9, T10> f9,Func<T10, T11> f10,Func<T11, T12> f11,Func<T12, T13> f12,Func<T13, T14> f13,Func<T14, T15> f14) => new TransformPipe<T0, T15>(f => f14(f13(f12(f11(f10(f9(f8(f7(f6(f5(f4(f3(f2(f1(f0(f))))))))))))))));
    public static ITransformPipe<T0, T16> Combine<T0,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14,T15,T16>(this ISourcePipe<T0> sourcePipe, Func<T0, T1> f0,Func<T1, T2> f1,Func<T2, T3> f2,Func<T3, T4> f3,Func<T4, T5> f4,Func<T5, T6> f5,Func<T6, T7> f6,Func<T7, T8> f7,Func<T8, T9> f8,Func<T9, T10> f9,Func<T10, T11> f10,Func<T11, T12> f11,Func<T12, T13> f12,Func<T13, T14> f13,Func<T14, T15> f14,Func<T15, T16> f15) => new TransformPipe<T0, T16>(f => f15(f14(f13(f12(f11(f10(f9(f8(f7(f6(f5(f4(f3(f2(f1(f0(f)))))))))))))))));
    public static ITransformPipe<T0, T17> Combine<T0,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14,T15,T16,T17>(this ISourcePipe<T0> sourcePipe, Func<T0, T1> f0,Func<T1, T2> f1,Func<T2, T3> f2,Func<T3, T4> f3,Func<T4, T5> f4,Func<T5, T6> f5,Func<T6, T7> f6,Func<T7, T8> f7,Func<T8, T9> f8,Func<T9, T10> f9,Func<T10, T11> f10,Func<T11, T12> f11,Func<T12, T13> f12,Func<T13, T14> f13,Func<T14, T15> f14,Func<T15, T16> f15,Func<T16, T17> f16) => new TransformPipe<T0, T17>(f => f16(f15(f14(f13(f12(f11(f10(f9(f8(f7(f6(f5(f4(f3(f2(f1(f0(f))))))))))))))))));
    public static ITransformPipe<T0, T18> Combine<T0,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14,T15,T16,T17,T18>(this ISourcePipe<T0> sourcePipe, Func<T0, T1> f0,Func<T1, T2> f1,Func<T2, T3> f2,Func<T3, T4> f3,Func<T4, T5> f4,Func<T5, T6> f5,Func<T6, T7> f6,Func<T7, T8> f7,Func<T8, T9> f8,Func<T9, T10> f9,Func<T10, T11> f10,Func<T11, T12> f11,Func<T12, T13> f12,Func<T13, T14> f13,Func<T14, T15> f14,Func<T15, T16> f15,Func<T16, T17> f16,Func<T17, T18> f17) => new TransformPipe<T0, T18>(f => f17(f16(f15(f14(f13(f12(f11(f10(f9(f8(f7(f6(f5(f4(f3(f2(f1(f0(f)))))))))))))))))));
    public static ITransformPipe<T0, T19> Combine<T0,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14,T15,T16,T17,T18,T19>(this ISourcePipe<T0> sourcePipe, Func<T0, T1> f0,Func<T1, T2> f1,Func<T2, T3> f2,Func<T3, T4> f3,Func<T4, T5> f4,Func<T5, T6> f5,Func<T6, T7> f6,Func<T7, T8> f7,Func<T8, T9> f8,Func<T9, T10> f9,Func<T10, T11> f10,Func<T11, T12> f11,Func<T12, T13> f12,Func<T13, T14> f13,Func<T14, T15> f14,Func<T15, T16> f15,Func<T16, T17> f16,Func<T17, T18> f17,Func<T18, T19> f18) => new TransformPipe<T0, T19>(f => f18(f17(f16(f15(f14(f13(f12(f11(f10(f9(f8(f7(f6(f5(f4(f3(f2(f1(f0(f))))))))))))))))))));
    public static ITransformPipe<T0, T20> Combine<T0,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14,T15,T16,T17,T18,T19,T20>(this ISourcePipe<T0> sourcePipe, Func<T0, T1> f0,Func<T1, T2> f1,Func<T2, T3> f2,Func<T3, T4> f3,Func<T4, T5> f4,Func<T5, T6> f5,Func<T6, T7> f6,Func<T7, T8> f7,Func<T8, T9> f8,Func<T9, T10> f9,Func<T10, T11> f10,Func<T11, T12> f11,Func<T12, T13> f12,Func<T13, T14> f13,Func<T14, T15> f14,Func<T15, T16> f15,Func<T16, T17> f16,Func<T17, T18> f17,Func<T18, T19> f18,Func<T19, T20> f19) => new TransformPipe<T0, T20>(f => f19(f18(f17(f16(f15(f14(f13(f12(f11(f10(f9(f8(f7(f6(f5(f4(f3(f2(f1(f0(f)))))))))))))))))))));
    public static ITransformPipe<T0, T21> Combine<T0,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14,T15,T16,T17,T18,T19,T20,T21>(this ISourcePipe<T0> sourcePipe, Func<T0, T1> f0,Func<T1, T2> f1,Func<T2, T3> f2,Func<T3, T4> f3,Func<T4, T5> f4,Func<T5, T6> f5,Func<T6, T7> f6,Func<T7, T8> f7,Func<T8, T9> f8,Func<T9, T10> f9,Func<T10, T11> f10,Func<T11, T12> f11,Func<T12, T13> f12,Func<T13, T14> f13,Func<T14, T15> f14,Func<T15, T16> f15,Func<T16, T17> f16,Func<T17, T18> f17,Func<T18, T19> f18,Func<T19, T20> f19,Func<T20, T21> f20) => new TransformPipe<T0, T21>(f => f20(f19(f18(f17(f16(f15(f14(f13(f12(f11(f10(f9(f8(f7(f6(f5(f4(f3(f2(f1(f0(f))))))))))))))))))))));
    public static ITransformPipe<T0, T22> Combine<T0,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14,T15,T16,T17,T18,T19,T20,T21,T22>(this ISourcePipe<T0> sourcePipe, Func<T0, T1> f0,Func<T1, T2> f1,Func<T2, T3> f2,Func<T3, T4> f3,Func<T4, T5> f4,Func<T5, T6> f5,Func<T6, T7> f6,Func<T7, T8> f7,Func<T8, T9> f8,Func<T9, T10> f9,Func<T10, T11> f10,Func<T11, T12> f11,Func<T12, T13> f12,Func<T13, T14> f13,Func<T14, T15> f14,Func<T15, T16> f15,Func<T16, T17> f16,Func<T17, T18> f17,Func<T18, T19> f18,Func<T19, T20> f19,Func<T20, T21> f20,Func<T21, T22> f21) => new TransformPipe<T0, T22>(f => f21(f20(f19(f18(f17(f16(f15(f14(f13(f12(f11(f10(f9(f8(f7(f6(f5(f4(f3(f2(f1(f0(f)))))))))))))))))))))));
    public static ITransformPipe<T0, T23> Combine<T0,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14,T15,T16,T17,T18,T19,T20,T21,T22,T23>(this ISourcePipe<T0> sourcePipe, Func<T0, T1> f0,Func<T1, T2> f1,Func<T2, T3> f2,Func<T3, T4> f3,Func<T4, T5> f4,Func<T5, T6> f5,Func<T6, T7> f6,Func<T7, T8> f7,Func<T8, T9> f8,Func<T9, T10> f9,Func<T10, T11> f10,Func<T11, T12> f11,Func<T12, T13> f12,Func<T13, T14> f13,Func<T14, T15> f14,Func<T15, T16> f15,Func<T16, T17> f16,Func<T17, T18> f17,Func<T18, T19> f18,Func<T19, T20> f19,Func<T20, T21> f20,Func<T21, T22> f21,Func<T22, T23> f22) => new TransformPipe<T0, T23>(f => f22(f21(f20(f19(f18(f17(f16(f15(f14(f13(f12(f11(f10(f9(f8(f7(f6(f5(f4(f3(f2(f1(f0(f))))))))))))))))))))))));
    public static ITransformPipe<T0, T24> Combine<T0,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14,T15,T16,T17,T18,T19,T20,T21,T22,T23,T24>(this ISourcePipe<T0> sourcePipe, Func<T0, T1> f0,Func<T1, T2> f1,Func<T2, T3> f2,Func<T3, T4> f3,Func<T4, T5> f4,Func<T5, T6> f5,Func<T6, T7> f6,Func<T7, T8> f7,Func<T8, T9> f8,Func<T9, T10> f9,Func<T10, T11> f10,Func<T11, T12> f11,Func<T12, T13> f12,Func<T13, T14> f13,Func<T14, T15> f14,Func<T15, T16> f15,Func<T16, T17> f16,Func<T17, T18> f17,Func<T18, T19> f18,Func<T19, T20> f19,Func<T20, T21> f20,Func<T21, T22> f21,Func<T22, T23> f22,Func<T23, T24> f23) => new TransformPipe<T0, T24>(f => f23(f22(f21(f20(f19(f18(f17(f16(f15(f14(f13(f12(f11(f10(f9(f8(f7(f6(f5(f4(f3(f2(f1(f0(f)))))))))))))))))))))))));
    public static ITransformPipe<T0, T25> Combine<T0,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14,T15,T16,T17,T18,T19,T20,T21,T22,T23,T24,T25>(this ISourcePipe<T0> sourcePipe, Func<T0, T1> f0,Func<T1, T2> f1,Func<T2, T3> f2,Func<T3, T4> f3,Func<T4, T5> f4,Func<T5, T6> f5,Func<T6, T7> f6,Func<T7, T8> f7,Func<T8, T9> f8,Func<T9, T10> f9,Func<T10, T11> f10,Func<T11, T12> f11,Func<T12, T13> f12,Func<T13, T14> f13,Func<T14, T15> f14,Func<T15, T16> f15,Func<T16, T17> f16,Func<T17, T18> f17,Func<T18, T19> f18,Func<T19, T20> f19,Func<T20, T21> f20,Func<T21, T22> f21,Func<T22, T23> f22,Func<T23, T24> f23,Func<T24, T25> f24) => new TransformPipe<T0, T25>(f => f24(f23(f22(f21(f20(f19(f18(f17(f16(f15(f14(f13(f12(f11(f10(f9(f8(f7(f6(f5(f4(f3(f2(f1(f0(f))))))))))))))))))))))))));
    public static ITransformPipe<T0, T26> Combine<T0,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14,T15,T16,T17,T18,T19,T20,T21,T22,T23,T24,T25,T26>(this ISourcePipe<T0> sourcePipe, Func<T0, T1> f0,Func<T1, T2> f1,Func<T2, T3> f2,Func<T3, T4> f3,Func<T4, T5> f4,Func<T5, T6> f5,Func<T6, T7> f6,Func<T7, T8> f7,Func<T8, T9> f8,Func<T9, T10> f9,Func<T10, T11> f10,Func<T11, T12> f11,Func<T12, T13> f12,Func<T13, T14> f13,Func<T14, T15> f14,Func<T15, T16> f15,Func<T16, T17> f16,Func<T17, T18> f17,Func<T18, T19> f18,Func<T19, T20> f19,Func<T20, T21> f20,Func<T21, T22> f21,Func<T22, T23> f22,Func<T23, T24> f23,Func<T24, T25> f24,Func<T25, T26> f25) => new TransformPipe<T0, T26>(f => f25(f24(f23(f22(f21(f20(f19(f18(f17(f16(f15(f14(f13(f12(f11(f10(f9(f8(f7(f6(f5(f4(f3(f2(f1(f0(f)))))))))))))))))))))))))));
    public static ITransformPipe<T0, T27> Combine<T0,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14,T15,T16,T17,T18,T19,T20,T21,T22,T23,T24,T25,T26,T27>(this ISourcePipe<T0> sourcePipe, Func<T0, T1> f0,Func<T1, T2> f1,Func<T2, T3> f2,Func<T3, T4> f3,Func<T4, T5> f4,Func<T5, T6> f5,Func<T6, T7> f6,Func<T7, T8> f7,Func<T8, T9> f8,Func<T9, T10> f9,Func<T10, T11> f10,Func<T11, T12> f11,Func<T12, T13> f12,Func<T13, T14> f13,Func<T14, T15> f14,Func<T15, T16> f15,Func<T16, T17> f16,Func<T17, T18> f17,Func<T18, T19> f18,Func<T19, T20> f19,Func<T20, T21> f20,Func<T21, T22> f21,Func<T22, T23> f22,Func<T23, T24> f23,Func<T24, T25> f24,Func<T25, T26> f25,Func<T26, T27> f26) => new TransformPipe<T0, T27>(f => f26(f25(f24(f23(f22(f21(f20(f19(f18(f17(f16(f15(f14(f13(f12(f11(f10(f9(f8(f7(f6(f5(f4(f3(f2(f1(f0(f))))))))))))))))))))))))))));
    public static ITransformPipe<T0, T28> Combine<T0,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14,T15,T16,T17,T18,T19,T20,T21,T22,T23,T24,T25,T26,T27,T28>(this ISourcePipe<T0> sourcePipe, Func<T0, T1> f0,Func<T1, T2> f1,Func<T2, T3> f2,Func<T3, T4> f3,Func<T4, T5> f4,Func<T5, T6> f5,Func<T6, T7> f6,Func<T7, T8> f7,Func<T8, T9> f8,Func<T9, T10> f9,Func<T10, T11> f10,Func<T11, T12> f11,Func<T12, T13> f12,Func<T13, T14> f13,Func<T14, T15> f14,Func<T15, T16> f15,Func<T16, T17> f16,Func<T17, T18> f17,Func<T18, T19> f18,Func<T19, T20> f19,Func<T20, T21> f20,Func<T21, T22> f21,Func<T22, T23> f22,Func<T23, T24> f23,Func<T24, T25> f24,Func<T25, T26> f25,Func<T26, T27> f26,Func<T27, T28> f27) => new TransformPipe<T0, T28>(f => f27(f26(f25(f24(f23(f22(f21(f20(f19(f18(f17(f16(f15(f14(f13(f12(f11(f10(f9(f8(f7(f6(f5(f4(f3(f2(f1(f0(f)))))))))))))))))))))))))))));
    public static ITransformPipe<T0, T29> Combine<T0,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14,T15,T16,T17,T18,T19,T20,T21,T22,T23,T24,T25,T26,T27,T28,T29>(this ISourcePipe<T0> sourcePipe, Func<T0, T1> f0,Func<T1, T2> f1,Func<T2, T3> f2,Func<T3, T4> f3,Func<T4, T5> f4,Func<T5, T6> f5,Func<T6, T7> f6,Func<T7, T8> f7,Func<T8, T9> f8,Func<T9, T10> f9,Func<T10, T11> f10,Func<T11, T12> f11,Func<T12, T13> f12,Func<T13, T14> f13,Func<T14, T15> f14,Func<T15, T16> f15,Func<T16, T17> f16,Func<T17, T18> f17,Func<T18, T19> f18,Func<T19, T20> f19,Func<T20, T21> f20,Func<T21, T22> f21,Func<T22, T23> f22,Func<T23, T24> f23,Func<T24, T25> f24,Func<T25, T26> f25,Func<T26, T27> f26,Func<T27, T28> f27,Func<T28, T29> f28) => new TransformPipe<T0, T29>(f => f28(f27(f26(f25(f24(f23(f22(f21(f20(f19(f18(f17(f16(f15(f14(f13(f12(f11(f10(f9(f8(f7(f6(f5(f4(f3(f2(f1(f0(f))))))))))))))))))))))))))))));
    public static ITransformPipe<T0, T30> Combine<T0,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14,T15,T16,T17,T18,T19,T20,T21,T22,T23,T24,T25,T26,T27,T28,T29,T30>(this ISourcePipe<T0> sourcePipe, Func<T0, T1> f0,Func<T1, T2> f1,Func<T2, T3> f2,Func<T3, T4> f3,Func<T4, T5> f4,Func<T5, T6> f5,Func<T6, T7> f6,Func<T7, T8> f7,Func<T8, T9> f8,Func<T9, T10> f9,Func<T10, T11> f10,Func<T11, T12> f11,Func<T12, T13> f12,Func<T13, T14> f13,Func<T14, T15> f14,Func<T15, T16> f15,Func<T16, T17> f16,Func<T17, T18> f17,Func<T18, T19> f18,Func<T19, T20> f19,Func<T20, T21> f20,Func<T21, T22> f21,Func<T22, T23> f22,Func<T23, T24> f23,Func<T24, T25> f24,Func<T25, T26> f25,Func<T26, T27> f26,Func<T27, T28> f27,Func<T28, T29> f28,Func<T29, T30> f29) => new TransformPipe<T0, T30>(f => f29(f28(f27(f26(f25(f24(f23(f22(f21(f20(f19(f18(f17(f16(f15(f14(f13(f12(f11(f10(f9(f8(f7(f6(f5(f4(f3(f2(f1(f0(f)))))))))))))))))))))))))))))));
}